using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.EVR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace TestsVersion_10
{
    [TestClass]
    public class IMFMediaEventGeneratorTest : COMBase, IMFAsyncCallback
    {
        private string BasePath;
        private string InputPath;
        

        AutoResetEvent m_are = new AutoResetEvent(false);
        IMFMediaEventGenerator m_meg;

        [TestInitialize]
        public void Prepare()
        {
            this.BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.InputPath = Path.Combine(this.BasePath, "Resources\\AspectRatio4x3.wmv");

            IMFSourceResolver pSourceResolver = null;

            // Create the source resolver.
            int hr = MFExtern.MFCreateSourceResolver(out pSourceResolver);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pSourceResolver);

            MFObjectType objectType;
            object pSource = null;
            hr = pSourceResolver.CreateObjectFromURL(
                    this.InputPath,
                    MFResolution.MediaSource,	// Create a source object.
                    null,						// Optional property store.
                    out objectType,				// Receives the created object type. 
                    out pSource					// Receives a pointer to the media source.
                );
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pSource);

            // Get the IMFMediaSource interface from the media source.
            m_meg = (IMFMediaEventGenerator)pSource;
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_meg);
            m_meg = null;
            m_are = null;
        }

        [TestMethod]
        public void IMFMediaEventGenerator_Tests()
        {
            // Queue an event
            Guid extendedType = Guid.NewGuid();
            int hr = m_meg.QueueEvent(MediaEventType.MESourceStarted, extendedType, 323, new PropVariant("asdf"));
            MFError.ThrowExceptionForHR(hr);

            // Sync get event
            IMFMediaEvent pEvent;
            hr = m_meg.GetEvent(MFEventFlag.None, out pEvent);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pEvent);

            Guid et;
            hr = pEvent.GetExtendedType(out et);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(extendedType, et);
            int i;
            hr = pEvent.GetStatus(out i);
            Assert.AreEqual(323, i);

            PropVariant pv = new PropVariant();
            MFError.ThrowExceptionForHR(hr);
            hr = pEvent.GetValue(pv);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual("asdf", pv.GetValue());

            // Queue another event
            hr = m_meg.QueueEvent(MediaEventType.MESourcePaused, Guid.NewGuid(), 333, new PropVariant("xasdf"));
            MFError.ThrowExceptionForHR(hr);

            // Async get event.
            hr = m_meg.BeginGetEvent(this, this);
            MFError.ThrowExceptionForHR(hr);
            m_are.WaitOne(-1, true);
        }


        #region IMFAsyncCallback Members

        public int GetParameters(out MFASync pdwFlags, out MFAsyncCallbackQueue pdwQueue)
        {
            pdwFlags = 0;
            pdwQueue = 0;
            return E_NotImplemented;
        }

        public int Invoke(IMFAsyncResult pAsyncResult)
        {
            IMFMediaEvent pEvent;
            int hr = m_meg.EndGetEvent(pAsyncResult, out pEvent);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pEvent);
            m_are.Set();

            return S_Ok;
        }

        #endregion
    }
}
