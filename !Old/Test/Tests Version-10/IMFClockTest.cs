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
    public class IMFClockTest
    {
        IMFClock m_c;

        [TestInitialize]
        public void Prepare()
        {
            IMFPresentationTimeSource ppts = null;
            int hr = MFExtern.MFCreateSystemTimeSource(out ppts);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ppts);

            IMFPresentationClock pc;

            hr = MFExtern.MFCreatePresentationClock(out pc);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pc);

            hr = pc.SetTimeSource(ppts);
            MFError.ThrowExceptionForHR(hr);

            m_c = pc;
            Assert.IsNotNull(m_c);
            

            //IMFMediaSession ms;

            //hr = MFExtern.MFCreateMediaSession(null, out ms);
            //MFError.ThrowExceptionForHR(hr);
            //Assert.IsNotNull(ms);

            //hr = ms.GetClock(out m_c);
            //MFError.ThrowExceptionForHR(hr);
            //Assert.IsNotNull(m_c);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_c);
            m_c = null;
        }

        [TestMethod]
        public void IMFClock_TestsGetClockCharacteristics()
        {
            MFClockCharacteristicsFlags c;

            int hr = m_c.GetClockCharacteristics(out c);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFClock_TestsGetCorrelatedTime()
        {
            long l, l2;
            int hr = m_c.GetCorrelatedTime(0, out l, out l2);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFClock_TestsGetContinuityKey()
        {
            int iKey;
            int hr = m_c.GetContinuityKey(out iKey);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFClock_TestsGetState()
        {
            MFClockState pState;
            int hr = m_c.GetState(0, out pState);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFClock_TestsGetProperties()
        {
            MFClockProperties pProp;

            int hr = m_c.GetProperties(out pProp);
            MFError.ThrowExceptionForHR(hr);
        }


    }
}
