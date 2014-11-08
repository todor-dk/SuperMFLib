using System;
using System.Diagnostics;

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsVersion_11
{
    [TestClass]
    public class IMFRateControlTest
    {
        IMFRateControl m_rc;

        public void DoTests()
        {
            GetInterface();

            TestRate();
        }

        private void TestRate()
        {
            bool b = true;
            float pf;
            int hr = m_rc.GetRate(ref b, out pf);
            MFError.ThrowExceptionForHR(hr);

            hr = m_rc.SetRate(true, 0.5f);
            MFError.ThrowExceptionForHR(hr);
        }

        private void GetInterface()
        {
            IMFMediaSession ms;
            int hr = MFExtern.MFCreateMediaSession(null, out ms);
            MFError.ThrowExceptionForHR(hr);
            m_rc = ms as IMFRateControl;
        }
    }
}
