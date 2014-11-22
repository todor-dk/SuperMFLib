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
    public class IMFActivateTest
    {
        IMFActivate m_a;

        [TestInitialize]
        public void Prepare()
        {
            int hr;
            hr = MFExtern.MFCreateVideoRendererActivate(IntPtr.Zero, out m_a);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_a);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_a);
            m_a = null;
        }

        [TestMethod]
        public void IMFActivate_TestAttributes()
        {
            AttributesTestHelper.TestAll(m_a);
        }

        [TestMethod]
        public void IMFActivate_DoTests()
        {
            int hr;
            object o;

            hr = m_a.ActivateObject(typeof(IMFGetService).GUID, out o);
            MFError.ThrowExceptionForHR(hr);

            Assert.IsNotNull(o);

            hr = m_a.DetachObject(); 
            // Not implemented is OK. The test object we use doesn't implement this.
            if (hr != COMBase.E_NotImplemented)
                MFError.ThrowExceptionForHR(hr);

            hr = m_a.ShutdownObject();
            MFError.ThrowExceptionForHR(hr);
        }


    }
}
