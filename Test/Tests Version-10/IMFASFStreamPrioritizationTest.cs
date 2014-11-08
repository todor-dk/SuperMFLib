// This interface isn't implemented by anything in vista sp0
#if false
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
    public class IMFASFStreamPrioritizationTest
    {
        private IMFASFStreamPrioritization m_sp;

        public void DoTests()
        {
            GetInterface();
        }

        private void GetInterface()
        {
            IMFASFProfile ap;
            IMFASFStreamPrioritization o;

            MFExtern.MFCreateASFProfile(out ap);

            ap.CreateStreamPrioritization(out o);
            //m_sp = o as IMFASFStreamPrioritization;
        }
    }
}
#endif