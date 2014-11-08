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
    public class IMFASFMutualExclusionTest
    {
        private IMFASFProfile m_p;
        private IMFASFMutualExclusion m_ame;

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateASFProfile(out m_p);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_p);

            hr = m_p.CreateMutualExclusion(out m_ame);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_ame);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_ame);
            COMBase.SafeRelease(m_p);
            m_ame = null;
            m_p = null;
        }

        [TestMethod]
        public void IMFASFMutualExclusion_TestType()
        {
            Guid g;

            int hr = m_ame.GetType(out g);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreNotEqual(Guid.Empty, g);

            Guid g2;
            if (g == MFASFMutexType.Language)
                g2 = MFASFMutexType.Bitrate;
            else
                g2 = MFASFMutexType.Language;

            hr = m_ame.SetType(g2);
            MFError.ThrowExceptionForHR(hr);

            Guid g3;
            hr = m_ame.GetType(out g3);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(g2, g3);

            m_ame.SetType(g);
        }

        [TestMethod]
        public void IMFASFMutualExclusion_TestRecord()
        {
            int iRec = -1;
            int iCnt = -1;

            int hr = m_ame.AddRecord(out iRec);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(0, iRec);

            hr = m_ame.GetRecordCount(out iCnt);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, iCnt);

            hr = m_ame.RemoveRecord(iRec);
            MFError.ThrowExceptionForHR(hr);

            hr = m_ame.GetRecordCount(out iCnt);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(0, iCnt);
        }

        [TestMethod]
        private void IMFASFMutualExclusion_TestStream()
        {
            int iRec = -1;
            short[] wa;

            int hr = m_ame.AddRecord(out iRec);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(0, iRec);

            hr = m_ame.AddStreamForRecord(iRec, 17);
            MFError.ThrowExceptionForHR(hr);
            hr = m_ame.AddStreamForRecord(iRec, 18);
            MFError.ThrowExceptionForHR(hr);

            int i = -1;
            hr = m_ame.GetStreamsForRecord(iRec, null, ref i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(2, i);

            wa = new short[i];
            hr = m_ame.GetStreamsForRecord(iRec, wa, ref i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(2, i);
            Assert.AreEqual(17, wa[0]);
            Assert.AreEqual(18, wa[1]);

            hr = m_ame.RemoveStreamFromRecord(iRec, 17);
            MFError.ThrowExceptionForHR(hr);

            hr = m_ame.GetStreamsForRecord(iRec, wa, ref i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, i);
            Assert.AreEqual(18, wa[0]);

            hr = m_ame.RemoveRecord(iRec);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFASFMutualExclusion_TestClone()
        {
            IMFASFMutualExclusion ame;

            int hr = m_ame.Clone(out ame);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ame);
        }





    }
}
