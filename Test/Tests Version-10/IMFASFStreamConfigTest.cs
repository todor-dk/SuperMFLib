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
    public class IMFASFStreamConfigTest
    {
        private IMFASFStreamConfig m_sc;
        private IMFMediaType m_mt;

        [TestInitialize]
        public void Prepare()
        {
            FourCC cc4 = new FourCC("YUY2");
            IMFASFProfile ap;

            int hr = MFExtern.MFCreateASFProfile(out ap);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ap);

            hr = MFExtern.MFCreateMediaType(out m_mt);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_mt);

            hr = m_mt.SetGUID(MFAttributesClsid.MF_MT_SUBTYPE, cc4.ToMediaSubtype());
            MFError.ThrowExceptionForHR(hr);
            hr = m_mt.SetGUID(MFAttributesClsid.MF_MT_MAJOR_TYPE, MFMediaType.Video);
            MFError.ThrowExceptionForHR(hr);

            hr = ap.CreateStream(m_mt, out m_sc);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_sc);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_sc);
            COMBase.SafeRelease(m_mt);
            m_sc = null;
            m_mt = null;
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestAttributes()
        {
            AttributesTestHelper.TestAll(m_sc);
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestMT()
        {
            IMFMediaType mt;

            int hr = m_sc.GetMediaType(out mt);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(mt);
            Assert.AreSame(m_mt, mt);

            hr = m_sc.SetMediaType(mt);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestStreamNumber()
        {
            int hr = m_sc.SetStreamNumber(123);
            MFError.ThrowExceptionForHR(hr);
            short s = m_sc.GetStreamNumber();
            Assert.AreEqual(123, s);
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestType()
        {
            Guid g;

            int hr = m_sc.GetStreamType(out g);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(MFMediaType.Video, g);
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestPayload()
        {
            int iSize = sizeof(Int64) + 2;
            IntPtr ip = Marshal.AllocCoTaskMem(iSize);
            Assert.AreNotEqual(IntPtr.Zero, ip);
            Marshal.WriteInt64(ip, 0x1234567890ABCDEFL);

            int hr = m_sc.AddPayloadExtension(MFASFSampleExtension.SampleDuration, 2, ip, iSize);
            MFError.ThrowExceptionForHR(hr);

            short s = -1;
            hr = m_sc.GetPayloadExtensionCount(out s);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, s);

            int es = iSize;
            Guid g;
            short ds = -1;
            IntPtr ip2 = Marshal.AllocCoTaskMem(iSize);
            Assert.AreNotEqual(IntPtr.Zero, ip2);
            hr = m_sc.GetPayloadExtension(0, out g, out ds, ip2, ref es);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(MFASFSampleExtension.SampleDuration, g);
            Assert.AreEqual(2, ds);
            Assert.AreEqual(0x1234567890ABCDEFL, Marshal.ReadInt64(ip2));
            Assert.AreEqual(iSize, es);

            hr = m_sc.RemoveAllPayloadExtensions();
            MFError.ThrowExceptionForHR(hr);

            hr = m_sc.GetPayloadExtensionCount(out s);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(0, s);
        }

        [TestMethod]
        public void IMFASFStreamConfig_TestClone()
        {
            IMFASFStreamConfig sc;

            int hr = m_sc.Clone(out sc);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(sc);
        }

        



    }
}
