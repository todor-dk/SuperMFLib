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
    public class IMFPresentationTimeSourceTest
    {
        IMFPresentationTimeSource m_pts;

        public void DoTests()
        {
            IMFClock pc;

            int hr = MFExtern.MFCreateSystemTimeSource(out m_pts);
            MFError.ThrowExceptionForHR(hr);
            hr = m_pts.GetUnderlyingClock(out pc);
            MFError.ThrowExceptionForHR(hr);
        }
    }
}
