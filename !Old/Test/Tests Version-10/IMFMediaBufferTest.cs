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
    public class IMFMediaBufferTest
    {
        IMFMediaBuffer m_mb;

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateMemoryBuffer(100, out m_mb);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_mb);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_mb);
            m_mb = null;
        }

        [TestMethod]
        public void IMFMediaBuffer_Tests()
        {
            TestSetCurrentLength();
            TestGetMaxLength();

            TestLock();
            TestUnlock();
        }

        private void TestSetCurrentLength()
        {
            int i;

            int hr = m_mb.SetCurrentLength(33);
            MFError.ThrowExceptionForHR(hr);
            hr = m_mb.GetCurrentLength(out i);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(33, i);
        }

        private void TestGetMaxLength()
        {
            int i;

            int hr = m_mb.GetMaxLength(out i);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(100, i);
        }

        private void TestLock()
        {
            IntPtr ip;
            int imax, iCur;
            int hr = m_mb.Lock(out ip, out imax, out iCur);
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestUnlock()
        {
            int hr = m_mb.Unlock();
            MFError.ThrowExceptionForHR(hr);
        }




    }
}
