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
    public class IMFASFProfileTest
    {
        private IMFASFProfile m_p;

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateASFProfile(out m_p);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_p);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_p);
            m_p = null;
        }

        [TestMethod]
        public void IMFASFProfile_TestAttributes()
        {
            AttributesTestHelper.TestAll(m_p);
        }

        [TestMethod]
        public void IMFASFProfile_TestCreateStream()
        {
            FourCC cc4 = new FourCC("YUY2");

            IMFMediaType mt;
            int hr = MFExtern.MFCreateMediaType(out mt);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(mt);

            hr = mt.SetGUID(MFAttributesClsid.MF_MT_SUBTYPE, cc4.ToMediaSubtype());
            MFError.ThrowExceptionForHR(hr);
            hr = mt.SetGUID(MFAttributesClsid.MF_MT_MAJOR_TYPE, MFMediaType.Video);
            MFError.ThrowExceptionForHR(hr);

            IMFASFStreamConfig pStream;
            hr = m_p.CreateStream(mt, out pStream);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pStream);

            hr = m_p.SetStream(pStream);
            MFError.ThrowExceptionForHR(hr);

            int i = -1;
            hr = m_p.GetStreamCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, i);

            short s;
            IMFASFStreamConfig pStream2;
            hr = m_p.GetStream(0, out s, out pStream2);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pStream2);

            IMFASFStreamConfig pStream3;
            hr = m_p.GetStreamByNumber(s, out pStream3);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreSame(pStream2, pStream3);

            IMFASFProfile p2;
            hr = m_p.Clone(out p2);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(p2);

            i = -1;
            hr = p2.GetStreamCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, i);
            hr = p2.RemoveStream(0);
            MFError.ThrowExceptionForHR(hr);
            int i2 = -1;
            hr = p2.GetStreamCount(out i2);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(i - 1, i2);
        }

        [TestMethod]
        public void IMFASFProfile_TestExclusion()
        {
            IMFASFMutualExclusion me;
            int hr = m_p.CreateMutualExclusion(out me);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(me);

            hr = m_p.AddMutualExclusion(me);
            MFError.ThrowExceptionForHR(hr);

            int i = -1;
            hr = m_p.GetMutualExclusionCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, i);

            IMFASFMutualExclusion me2;
            hr = m_p.GetMutualExclusion(0, out me2);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(me2);
            Assert.AreSame(me2, me);

            hr = m_p.RemoveMutualExclusion(0);
            MFError.ThrowExceptionForHR(hr);

            int i2 = -1;
            hr = m_p.GetMutualExclusionCount(out i2);
            Assert.AreEqual(0, i2);
        }

        [TestMethod]
        public void IMFASFProfile_TestClone()
        {
            IMFASFProfile ap;
            int hr = m_p.Clone(out ap);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ap);
        }

        [TestMethod]
        public void IMFASFProfile_TestPrioritization()
        {
            IMFASFStreamPrioritization sp = null;
            int hr = m_p.CreateStreamPrioritization(out sp);
            Assert.AreEqual(COMBase.E_NotImplemented, hr); // Microsoft: Not supported.
            Assert.IsNull(sp);

            hr = m_p.GetStreamPrioritization(out sp);
            if ((hr != COMBase.S_Ok) && (hr != COMBase.E_NotImplemented))
                Assert.Fail(); // Microsoft: Not supported.
            Assert.IsNull(sp);

            hr = m_p.AddStreamPrioritization(sp);
            if ((hr != COMBase.S_Ok) && (hr != COMBase.E_NotImplemented))
                Assert.Fail(); // Microsoft: Not supported.

            hr = m_p.RemoveStreamPrioritization();
            if ((hr != COMBase.S_Ok) && (hr != COMBase.E_NotImplemented))
                Assert.Fail(); // Microsoft: Not supported.
        }

    }
}
