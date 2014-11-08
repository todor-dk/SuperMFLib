using System;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;

using MediaFoundation;
using MediaFoundation.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsVersion_10
{
    [TestClass]
    public class IMFAttributesTest
    {
        IMFAttributes m_attr;

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateAttributes(out m_attr, 20);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_attr);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_attr);
            m_attr = null;
        }

        [TestMethod] 
        public void IMFAttributes_TestGetItem()
        {
            AttributesTestHelper.TestGetItem(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetUINT32()
        {
            AttributesTestHelper.TestGetUINT32(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetUINT64()
        {
            AttributesTestHelper.TestGetUINT64(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetDouble()
        {
            AttributesTestHelper.TestGetDouble(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetGuid()
        {
            AttributesTestHelper.TestGetGuid(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetString()
        {
            AttributesTestHelper.TestGetString(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetAllocatedString()
        {
            AttributesTestHelper.TestGetAllocatedString(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetBlob()
        {
            AttributesTestHelper.TestGetBlob(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetAllocatedBlob()
        {
            AttributesTestHelper.TestGetAllocatedBlob(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetUnknown()
        {
            AttributesTestHelper.TestGetUnknown(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestLockStore()
        {
            AttributesTestHelper.TestLockStore(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestGetItemByIndex()
        {
            AttributesTestHelper.TestGetItemByIndex(m_attr);
        }

        [TestMethod] 
        public void IMFAttributes_TestCopyAllItems()
        {
            AttributesTestHelper.TestCopyAllItems(m_attr);
        }

    }
}
