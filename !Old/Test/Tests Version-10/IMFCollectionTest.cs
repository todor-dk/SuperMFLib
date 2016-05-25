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
    public class IMFCollectionTest
    {
        IMFCollection m_col;

        [TestInitialize]
        public void Prepare()
        {
            int hr = MFExtern.MFCreateCollection(out m_col);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(m_col);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_col);
            m_col = null;
        }

        [TestMethod]
        public void IMFCollection_Tests()
        {
            TestAddElement();
            TestGetElementCount(1);
            TestGetElement();
            TestInsertElementAt();
            TestGetElementCount(2);
            TestRemoveElement();
            TestGetElementCount(1);
            TestRemoveAllElements();
            TestGetElementCount(0);
        }

        private void TestAddElement()
        {
            int hr = m_col.AddElement(this);
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestGetElementCount(int iCnt)
        {
            int i = -1;
            int hr = m_col.GetElementCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(iCnt, i);
        }

        private void TestGetElement()
        {
            object o;
            int hr = m_col.GetElement(0, out o);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreSame(this, o);
        }

        private void TestInsertElementAt()
        {
            int hr = m_col.InsertElementAt(0, this);
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestRemoveElement()
        {
            object o;
            int hr = m_col.RemoveElement(0, out o);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreSame(this, o);
        }

        private void TestRemoveAllElements()
        {
            int hr = m_col.RemoveAllElements();
            MFError.ThrowExceptionForHR(hr);
        }
    }
}
