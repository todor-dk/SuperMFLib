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
    public class IMFMediaEventTest
    {
        IMFMediaEvent m_me;

        private static readonly Guid ExtendedType = Guid.NewGuid();

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateMediaEvent(
                MediaEventType.MESourceStarted,
                IMFMediaEventTest.ExtendedType,
                313,
                new PropVariant("asdf"),
                out m_me);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_me);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_me);
            m_me = null;
        }

        [TestMethod]
        public void IMFMediaEvent_TestGetType()
        {
            MediaEventType m;
            int hr = m_me.GetType(out m);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(MediaEventType.MESourceStarted, m);
        }

        [TestMethod]
        public void IMFMediaEvent_TestGetExtendedType()
        {
            Guid g;
            int hr = m_me.GetExtendedType(out g);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(IMFMediaEventTest.ExtendedType, g);
        }

        [TestMethod]
        public void IMFMediaEvent_TestGetStatus()
        {
            int i;
            int hr = m_me.GetStatus(out i);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(313, i);
        }

        [TestMethod]
        public void IMFMediaEvent_TestGetValue()
        {
            PropVariant p = new PropVariant("FDSA");
            int hr = m_me.GetValue(p);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual("asdf", p.GetValue());
        }

    }
}
