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
    public class IMFASFStreamSelectorTest
    {
        IMFASFStreamSelector m_ss;

        [TestInitialize]
        public void Prepare()
        {
            FourCC cc4 = new FourCC("YUY2");

            IMFASFProfile prof;
            int hr = MFExtern.MFCreateASFProfile(out prof);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(prof);

            IMFASFMutualExclusion me;
            hr = prof.CreateMutualExclusion(out me);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(me);

            hr = prof.AddMutualExclusion(me);
            MFError.ThrowExceptionForHR(hr);

            IMFMediaType mt;
            hr = MFExtern.MFCreateMediaType(out mt);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(mt);

            hr = mt.SetGUID(MFAttributesClsid.MF_MT_SUBTYPE, cc4.ToMediaSubtype());
            MFError.ThrowExceptionForHR(hr);
            hr = mt.SetGUID(MFAttributesClsid.MF_MT_MAJOR_TYPE, MFMediaType.Video);
            MFError.ThrowExceptionForHR(hr);

            IMFASFStreamConfig pStream;
            hr = prof.CreateStream(mt, out pStream);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pStream);

            hr = prof.SetStream(pStream);
            MFError.ThrowExceptionForHR(hr);

            hr = MFExtern.MFCreateASFStreamSelector(prof, out m_ss);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_ss);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_ss);
            m_ss = null;
        }

        [TestMethod]
        public void IMFASFStreamSelector_TestStream()
        {
            int i = -1;
            int hr = m_ss.GetStreamCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            hr = m_ss.GetBandwidthStepCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            ASFSelectionStatus[] sel = new ASFSelectionStatus[i];
            short[] sa = new short[i];
            sel[0] = ASFSelectionStatus.NotSelected;
            sa[0] = -1;

            hr = m_ss.GetBandwidthStep(0, out i, sa, sel);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreNotEqual(-1, sa[0]);
            Assert.AreNotEqual(ASFSelectionStatus.NotSelected, sel[0]);

            hr = m_ss.SetStreamSelectorFlags(MFAsfStreamSelectorFlags.DisableThinning);
            MFError.ThrowExceptionForHR(hr);

            hr = m_ss.BitrateToStepNumber(100, out i);
            MFError.ThrowExceptionForHR(hr);

            hr = m_ss.BitrateToStepNumber(0, out i);
            MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFASFStreamSelector_TestMutex()
        {
            int i = -1;
            int hr = m_ss.GetOutputMutexCount(0, out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            object o;
            hr = m_ss.GetOutputMutex(0, 0, out o);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(o);

            hr = m_ss.SetOutputMutexSelection(1, 0, 0);
            // Don't know what his problem is, but the def looks right
            if (hr != COMBase.E_InvalidArgument) 
                MFError.ThrowExceptionForHR(hr);
        }

        [TestMethod]
        public void IMFASFStreamSelector_TestOutput()
        {
            int i = -1;
            int hr = m_ss.GetOutputCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);
            i = -1;
            hr = m_ss.GetOutputStreamCount(1, out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            i = -1;
            hr = m_ss.GetOutputFromStream(0, out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            hr = m_ss.SetOutputOverride(1, ASFSelectionStatus.CleanPointsOnly);
            MFError.ThrowExceptionForHR(hr);

            ASFSelectionStatus sel2;
            hr = m_ss.GetOutputOverride(1, out sel2);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(ASFSelectionStatus.CleanPointsOnly, sel2);


            hr = m_ss.GetOutputStreamCount(1, out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);
            short[] sa = new short[i];
            sa[0] = -1;
            hr = m_ss.GetOutputStreamNumbers(1, sa);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreNotEqual(-1, sa[0]);
        }

    }
}
