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

namespace TestsVersion_10
{
    [TestClass]
    public class IMFMediaEventQueueTest : COMBase, IMFAsyncCallback
    {
        IMFMediaEventQueue m_meq;
        AutoResetEvent m_are = new AutoResetEvent(false);

        private void Prepare()
        {
            int hr = MFExtern.MFCreateEventQueue(out m_meq);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_meq);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_meq);
            m_meq = null;
        }

        [TestMethod]
        public void IMFMediaEventQueue_Tests()
        {
            // Idiotic MF requires an MTA. The unit tests run STA and this throws an exception.
            // To work around this, create an MTA thread and run the test in tha MTA thread.
            Thread thread = new Thread(this.TestsWorker);
            thread.SetApartmentState(ApartmentState.MTA);
            thread.Start();
            thread.Join();
        }

        private void TestsWorker()
        {
            TestQueueEvent();
            TestGetEvent();
            TestQueueEventParamUnk();
            TestBeginGetEvent();

            TestQueueEventParamVar();
            TestShutdown();
        }

        private void TestQueueEvent()
        {
            IMFMediaEvent pEvent;

            int hr = MFExtern.MFCreateMediaEvent(
                MediaEventType.MESourceStarted,
                Guid.Empty,
                0,
                null,
                out pEvent
                );
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pEvent);

            hr = m_meq.QueueEvent(pEvent);
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestGetEvent()
        {
            IMFMediaEvent pEvent;

            int hr = m_meq.GetEvent(MFEventFlag.NoWait, out pEvent);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pEvent);
        }

        private void TestQueueEventParamUnk()
        {
            int hr = m_meq.QueueEventParamUnk(MediaEventType.MESessionEnded, Guid.Empty, 0, this);
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestBeginGetEvent()
        {
            int hr = m_meq.BeginGetEvent(this, null);
            MFError.ThrowExceptionForHR(hr);
            m_are.WaitOne(-1, true);
        }

        private void TestQueueEventParamVar()
        {
            IMFMediaEvent pEvent;
            Guid g = Guid.NewGuid();
            PropVariant p = new PropVariant();

            int hr = m_meq.QueueEventParamVar(MediaEventType.MESessionClosed, g, 0, new PropVariant("asdf"));
            MFError.ThrowExceptionForHR(hr);

            hr = m_meq.GetEvent(MFEventFlag.None, out pEvent);
            MFError.ThrowExceptionForHR(hr);

            hr = pEvent.GetValue(p);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual("asdf", p.GetValue());
        }

        private void TestShutdown()
        {
            int hr = m_meq.Shutdown();
            MFError.ThrowExceptionForHR(hr);
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

            int hr = m_meq.EndGetEvent(pAsyncResult, out pEvent);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pEvent);

            PropVariant p = new PropVariant();
            hr = pEvent.GetValue(p);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreSame(this, p.GetValue());

            m_are.Set();

            return S_Ok;
        }

        #endregion
    }
}
