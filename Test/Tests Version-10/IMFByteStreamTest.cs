using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

using MediaFoundation;
using MediaFoundation.Misc;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace TestsVersion_10
{
    [ComVisible(true)]
    [TestClass]
    public class IMFByteStreamTest : COMBase, IMFAsyncCallback
    {
        private string BasePath;
        private string InputPath;
        private string TargetPath;

        IMFByteStream m_bs;
        AutoResetEvent m_mre = new AutoResetEvent(false);
        bool m_write = false;

        [TestInitialize]
        public void Prepare()
        {
            this.BasePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            this.InputPath = Path.Combine(this.BasePath, "Resources\\AspectRatio4x3.wmv");
            this.TargetPath = Path.Combine(this.BasePath, "test.wmv");
            Assert.IsTrue(File.Exists(this.InputPath));

            IMFSourceResolver sr;
            int hr = MFExtern.MFCreateSourceResolver(out sr);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(sr);

            MFObjectType pObjectType;
            object pSource;
            hr = sr.CreateObjectFromURL(
                this.InputPath,
                MFResolution.ByteStream,
                null,
                out pObjectType,
                out pSource);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(MFObjectType.ByteStream, pObjectType);
            Assert.IsNotNull(pSource);

            m_bs = pSource as IMFByteStream;
            Assert.IsNotNull(m_bs);
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(m_bs);
            m_bs = null;
            if (File.Exists(this.TargetPath))
                File.Delete(this.TargetPath);
        }


        //const string path = @"C:\sourceforge\mflib\Test\v1.0\test.wmv";


        [TestMethod]
        public void IMFByteStream_Tests()
        {
            TestGetCapabilities();
            TestGetLength();
            TestGetCurrentPosition();
            TestIsEndOfStream();

            TestRead();
            TestSeek();
            TestBeginRead();
            TestClose();

            TestSetLength();
            TestWrite();
            TestBeginWrite();
            TestFlush();
            TestClose();
        }

        private void TestGetCapabilities()
        {
            MFByteStreamCapabilities pcap;

            int hr = m_bs.GetCapabilities(out pcap);
            MFError.ThrowExceptionForHR(hr);

            Assert.IsTrue(pcap == (MFByteStreamCapabilities.IsSeekable | MFByteStreamCapabilities.IsReadable));
        }

        private void TestGetLength()
        {
            long l;

            int hr = m_bs.GetLength(out l);
            MFError.ThrowExceptionForHR(hr);
            //Assert.AreEqual(2163028, l);
        }

        private void TestGetCurrentPosition()
        {
            long l;

            int hr = m_bs.SetCurrentPosition(1);
            MFError.ThrowExceptionForHR(hr);
            hr = m_bs.GetCurrentPosition(out l);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, l);
        }

        private void TestIsEndOfStream()
        {
            bool b;

            int hr = m_bs.IsEndOfStream(out b);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsFalse(b);
        }

        private void TestRead()
        {
            int iReq = 32;
            int iRead = -1;
            IntPtr b = Marshal.AllocCoTaskMem(iReq);

            int hr = m_bs.Read(b, iReq, out iRead);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(iReq, iRead);

            Marshal.FreeCoTaskMem(b);
        }

        private void TestSeek()
        {
            long l;
            int hr = m_bs.Seek(MFByteStreamSeekOrigin.Current, -32, MFByteStreamSeekingFlags.None, out l);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(1, l);
        }

        private void TestBeginRead()
        {
            int iReq = 32;
            IntPtr b = Marshal.AllocCoTaskMem(iReq);

            int hr = m_bs.BeginRead(b, iReq, this, this);
            MFError.ThrowExceptionForHR(hr);
            m_mre.WaitOne(-1, true);

            Marshal.FreeCoTaskMem(b);
        }

        private void TestSetLength()
        {

            if (File.Exists(this.TargetPath))
                File.Delete(this.TargetPath);
            using (FileStream fs = File.Create(this.TargetPath, 1024))
            {
            }

            IMFSourceResolver sr;
            int hr = MFExtern.MFCreateSourceResolver(out sr);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(sr);

            MFObjectType pObjectType;
            object pSource;
            hr = sr.CreateObjectFromURL(
                @"file://" + this.TargetPath,
                MFResolution.ByteStream | MFResolution.Write,
                null,
                out pObjectType,
                out pSource);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(MFObjectType.ByteStream, pObjectType);
            Assert.IsNotNull(pSource);

            COMBase.SafeRelease(m_bs);
            m_bs = (IMFByteStream)pSource;
            Assert.IsNotNull(m_bs);

            hr = m_bs.SetLength(100);
            MFError.ThrowExceptionForHR(hr);
            m_write = true;
        }

        private void TestWrite()
        {
            int iWrote = -1;
            int iReq = 32;
            IntPtr b = Marshal.AllocCoTaskMem(iReq);
            int hr = m_bs.Write(b, iReq, out iWrote);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(iReq, iWrote);
            Marshal.FreeCoTaskMem(b);
        }

        private void TestBeginWrite()
        {
            int iReq = 32;
            IntPtr b = Marshal.AllocCoTaskMem(iReq);
            int hr = m_bs.BeginWrite(b, iReq, this, this);
            MFError.ThrowExceptionForHR(hr);

            m_mre.WaitOne(-1, true);
            Marshal.FreeCoTaskMem(b);
        }

        private void TestFlush()
        {
            int hr = m_bs.Flush();
            MFError.ThrowExceptionForHR(hr);
        }

        private void TestClose()
        {
            int hr = m_bs.Close();
            MFError.ThrowExceptionForHR(hr);
        }




        #region IMFAsyncCallback Members

        public int GetParameters(out MFASync pdwFlags, out MFAsyncCallbackQueue pdwQueue)
        {
            pdwFlags = 0;
            pdwQueue = 0;
            return E_NotImplemented;
        }

        public int Invoke(IMFAsyncResult pAsyncResult)
        {
            int i;
            object o;
            IntPtr ip = Marshal.AllocCoTaskMem(8);

            int hr = pAsyncResult.GetState(out o);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreSame(this, o);

            ip = pAsyncResult.GetStateNoAddRef();
            Assert.AreNotEqual(IntPtr.Zero, ip);
            o = Marshal.GetObjectForIUnknown(ip);
            Assert.AreSame(this, o);

            hr = pAsyncResult.SetStatus(-1);
            MFError.ThrowExceptionForHR(hr);
            hr = pAsyncResult.GetStatus();
            Assert.AreEqual(-1, hr);

            try
            {
                // Since the IMFAsyncResult was created with no
                hr = pAsyncResult.GetObject(out o);
                Assert.AreEqual(COMBase.E_Pointer, hr);
            }
            catch (Exception e)
            {
                Assert.IsTrue(e is NullReferenceException);
            }


            if (!m_write)
            {
                i = -1;
                hr = m_bs.EndRead(pAsyncResult, out i);
                MFError.ThrowExceptionForHR(hr);
                Assert.AreEqual(32, i);
            }
            else
            {
                i = -1;
                hr = m_bs.EndWrite(pAsyncResult, out i);
                MFError.ThrowExceptionForHR(hr);
                Assert.AreEqual(32, i);
            }

            m_mre.Set();

            return 0;
        }

        #endregion
    }
}
