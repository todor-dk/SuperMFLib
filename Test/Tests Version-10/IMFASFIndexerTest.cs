/****************************************************************************
While the underlying libraries are covered by LGPL, this sample is released 
as public domain.  It is distributed in the hope that it will be useful, but 
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
or FITNESS FOR A PARTICULAR PURPOSE.  
*****************************************************************************/

using System;
using System.Runtime.InteropServices;

using MediaFoundation;
using MediaFoundation.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.IO;

// Test with c:\Program Files\Microsoft SDKs\Windows\v6.0\Samples\Multimedia\WMP_11\media\smooth.wmv

namespace TestsVersion_10
{
    // TODO: 
    //  IMFAsfIndexer.SetIndexStatus
    //  IMFAsfIndexer.GenerateIndexEntries
    //  IMFAsfIndexer.CommitIndex
    [TestClass]
    public class IMFAsfIndexerTest
    {
        private string FilePath;
        IMFByteStream pStream;
        IMFASFContentInfo pContentInfo;
        IMFASFSplitter pSplitter;
        IMFASFIndexer ai;

        [TestInitialize]
        public void Prepare()
        {
            string path = Assembly.GetExecutingAssembly().Location;
            this.FilePath = Path.Combine(Path.GetDirectoryName(path), "Resources\\smooth.wmv");

            Assert.IsTrue(File.Exists(this.FilePath));
        }

        [TestCleanup]
        public void CleanUp()
        {
            COMBase.SafeRelease(ai);
            COMBase.SafeRelease(pSplitter);
            COMBase.SafeRelease(pContentInfo);
            COMBase.SafeRelease(pStream);
            ai = null;
            pSplitter = null;
            pContentInfo = null;
            pStream = null;
        }

        [TestMethod]
        public void IMFAsfIndexer_DoTests()
        {
            // Open the file.
            OpenFile(this.FilePath, out pStream);

            // Read the ASF header.
            CreateContentInfo(pStream, out pContentInfo);

            // Create the ASF splitter.
            CreateASFSplitter(pContentInfo, out pSplitter);

            // Select the first video stream.
            bool bHasVideo = false;
            SelectVideoStream(pContentInfo, pSplitter, out bHasVideo);

            CreateIndexer(pContentInfo, out ai);

            // Parse the ASF file.
            if (bHasVideo)
                DisplayKeyFrames(ai, pStream, pSplitter);
        }


        private static void OpenFile(string sFileName, out IMFByteStream ppStream)
        {
            // Open a byte stream for the file.
            int hr = MFExtern.MFCreateFile(MFFileAccessMode.Read, MFFileOpenMode.FailIfNotExist, MFFileFlags.None, sFileName, out ppStream);
            MFError.ThrowExceptionForHR(hr);

            Assert.IsNotNull(ppStream);
        }

        /// <summary>
        /// Reads the ASF Header Object from a byte stream and returns a
        /// pointer to the ASF content information object.
        /// </summary>
        /// <param name="pStream">
        /// Pointer to the byte stream. The byte stream's 
        /// current read position must be at the start of the
        /// ASF Header Object.
        /// </param>
        /// <param name="ppContentInfo">Receives a pointer to the ASF content information object.</param>
        private static void CreateContentInfo(IMFByteStream pStream, out IMFASFContentInfo ppContentInfo)
        {
            long cbHeader = 0;

            const int MIN_ASF_HEADER_SIZE = 30;

            IMFMediaBuffer pBuffer;

            // Create the ASF content information object.
            int hr = MFExtern.MFCreateASFContentInfo(out ppContentInfo);
            MFError.ThrowExceptionForHR(hr);

            // Read the first 30 bytes to find the total header size.
            ReadDataIntoBuffer(pStream, MIN_ASF_HEADER_SIZE, out pBuffer);

            Assert.IsNotNull(pBuffer);

            try
            {
                hr = ppContentInfo.GetHeaderSize(pBuffer, out cbHeader);
                MFError.ThrowExceptionForHR(hr);

                Assert.AreNotEqual(0, cbHeader);

                // Pass the first 30 bytes to the content information object.
                hr = ppContentInfo.ParseHeader(pBuffer, 0);
                MFError.ThrowExceptionForHR(hr);
            }
            finally
            {
                COMBase.SafeRelease(pBuffer);
            }

            // Read the rest of the header and finish parsing the header.
            ReadDataIntoBuffer(pStream, (int)(cbHeader - MIN_ASF_HEADER_SIZE), out pBuffer);

            hr = ppContentInfo.ParseHeader(pBuffer, MIN_ASF_HEADER_SIZE);
            MFError.ThrowExceptionForHR(hr);
        }

        /// <summary>
        /// Reads data from a byte stream and returns a media buffer that contains the data.
        /// </summary>
        /// <param name="pStream"> Pointer to the byte stream</param>
        /// <param name="cbToRead">Number of bytes to read</param>
        /// <param name="ppBuffer">Receives a pointer to the buffer.</param>
        private static void ReadDataIntoBuffer(IMFByteStream pStream, int cbToRead, out IMFMediaBuffer ppBuffer)
        {
            IntPtr pData;
            int cbRead;   // Actual amount of data read
            int iMax, iCur;

            // Create the media buffer. This function allocates the memory.
            int hr = MFExtern.MFCreateMemoryBuffer(cbToRead, out ppBuffer);
            MFError.ThrowExceptionForHR(hr);

            Assert.IsNotNull(ppBuffer);

            // Access the buffer.
            hr = ppBuffer.Lock(out pData, out iMax, out iCur);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreNotEqual(IntPtr.Zero, pData);
            Assert.IsTrue(iMax >= cbToRead);

            try
            {
                // Read the data from the byte stream.
                hr = pStream.Read(pData, cbToRead, out cbRead);
                MFError.ThrowExceptionForHR(hr);

                Assert.IsTrue(cbRead >= 0);
                Assert.IsTrue(cbRead <= cbToRead);
            }
            finally
            {
                hr = ppBuffer.Unlock();
                MFError.ThrowExceptionForHR(hr);
                pData = IntPtr.Zero;
            }

            // Update the size of the valid data.
            hr = ppBuffer.SetCurrentLength(cbRead);
            MFError.ThrowExceptionForHR(hr);
        }

        /// <summary>
        /// Creates the ASF splitter.
        /// </summary>
        /// <param name="pContentInfo">Pointer to an initialized instance of the ASF content information object.</param>
        /// <param name="ppSplitter">Receives a pointer to the ASF splitter.</param>
        private static void CreateASFSplitter(IMFASFContentInfo pContentInfo, out IMFASFSplitter ppSplitter)
        {
            MFASFSplitterFlags f;

            int hr = MFExtern.MFCreateASFSplitter(out ppSplitter);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ppSplitter);
            hr = ppSplitter.Initialize(pContentInfo);
            MFError.ThrowExceptionForHR(hr);

            hr = ppSplitter.GetFlags(out f);
            MFError.ThrowExceptionForHR(hr);
        }

        /// <summary>
        /// Selects the first video stream for parsing with the ASF splitter.
        /// </summary>
        /// <param name="pContentInfo">Pointer to an initialized instance of the ASF content information object.</param>
        /// <param name="pSplitter">Pointer to the ASF splitter.</param>
        /// <param name="pbHasVideo">Receives TRUE if there is a video stream, or FALSE otherwise.</param>
        private static void SelectVideoStream(IMFASFContentInfo pContentInfo, IMFASFSplitter pSplitter, out bool pbHasVideo)
        {
            int cStreams;
            short wStreamID = 33;
            short[] wStreamIDs = new short[1];
            Guid streamType;
            bool bFoundVideo = false;

            IMFASFProfile pProfile;
            IMFASFStreamConfig pStream;

            // Get the ASF profile from the content information object.
            int hr = pContentInfo.GetProfile(out pProfile);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(pProfile);

            try
            {
                // Loop through all of the streams in the profile.
                hr = pProfile.GetStreamCount(out cStreams);
                MFError.ThrowExceptionForHR(hr);

                for (int i = 0; i < cStreams; i++)
                {
                    // Get the stream type and stream identifier.
                    hr = pProfile.GetStream(i, out wStreamID, out pStream);
                    MFError.ThrowExceptionForHR(hr);
                    Assert.IsNotNull(pStream);
                    
                    try
                    {
                        hr = pStream.GetStreamType(out streamType);
                        MFError.ThrowExceptionForHR(hr);

                        if (streamType == MFMediaType.Video)
                        {
                            bFoundVideo = true;
                            break;
                        }
                    }
                    finally
                    {
                        COMBase.SafeRelease(pStream);
                    }
                }
            }
            finally
            {
                COMBase.SafeRelease(pProfile);
            }

            // Select the video stream, if found.
            if (bFoundVideo)
            {
                // SelectStreams takes an array of stream identifiers.
                wStreamIDs[0] = wStreamID;
                hr = pSplitter.SelectStreams(wStreamIDs, 1);
                MFError.ThrowExceptionForHR(hr);
            }

            pbHasVideo = bFoundVideo;
        }

        private static void CreateIndexer(IMFASFContentInfo pContentInfo, out IMFASFIndexer ai)
        {
            MFAsfIndexerFlags f;
            long l;
            int i;
            IMFMediaBuffer mb;
            int hr;

            hr = MFExtern.MFCreateASFIndexer(out ai);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(ai);

            hr = MFExtern.MFCreateMemoryBuffer(1000, out mb);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsNotNull(mb);

            hr = ai.Initialize(pContentInfo);
            MFError.ThrowExceptionForHR(hr);

            hr = ai.GetIndexPosition(pContentInfo, out l);
            MFError.ThrowExceptionForHR(hr);

            hr = ai.GetFlags(out f);
            MFError.ThrowExceptionForHR(hr);

            hr = ai.SetFlags(f);
            MFError.ThrowExceptionForHR(hr);

            MFAsfIndexerFlags f2;
            hr = ai.GetFlags(out f2);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(f, f2);

            hr = ai.GetIndexByteStreamCount(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(i > 0);

            hr = mb.GetCurrentLength(out i);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(0, i);

            hr = ai.GetCompletedIndex(mb, 0);
            MFError.ThrowExceptionForHR(hr);

            hr = mb.GetCurrentLength(out i);
            MFError.ThrowExceptionForHR(hr);
            //Assert.IsTrue(i > 0);

            hr = ai.GetIndexWriteSpace(out l);
            MFError.ThrowExceptionForHR(hr);
            //Assert.IsTrue(l > 0);
        }

        /// <summary>
        /// Parses the video stream and displays information about the samples that contain key frames.
        /// </summary>
        /// <param name="ai"></param>
        /// <param name="pStream">
        /// Pointer to a byte stream. The byte stream's current read position must be at the start of the ASF Data Object.
        /// </param>
        /// <param name="pSplitter">Pointer to the ASF splitter.</param>
        private static void DisplayKeyFrames(IMFASFIndexer ai, IMFByteStream pStream, IMFASFSplitter pSplitter)
        {
            const int cbReadSize = 2048;  // Read size (arbitrary value)

            int cbData;             // Amount of data read
            ASFStatusFlags dwStatus;           // Parsing status
            short wStreamID;          // Stream identifier
            bool bIsKeyFrame = false;    // Is the sample a key frame?
            int cBuffers;           // Buffer count
            int cbTotalLength;      // Buffer length
            long hnsTime;            // Time stamp

            IMFMediaBuffer pBuffer;
            IMFSample pSample;

            IMFByteStream[] aia = new IMFByteStream[1];
            aia[0] = pStream;

            int hr = ai.SetIndexByteStreams(aia, 1);
            MFError.ThrowExceptionForHR(hr);

            ASFIndexIdentifier ii = new ASFIndexIdentifier();
            ii.guidIndexType = Guid.Empty;
            ii.wStreamNumber = 2;
            bool b;
            int i1 = 100;
            IntPtr ip = Marshal.AllocCoTaskMem(i1);
            ai.GetIndexStatus(ii, out b, ip, ref i1);
            long l;
            PropVariant pv = new PropVariant(50000000L);
            hr = ai.GetSeekPositionForValue(pv, ii, out l, IntPtr.Zero, out i1);
            MFError.ThrowExceptionForHR(hr);

            while (true)
            {
                // Read data into the buffer.
                ReadDataIntoBuffer(pStream, cbReadSize, out pBuffer);

                try
                {
                    hr = pBuffer.GetCurrentLength(out cbData);
                    MFError.ThrowExceptionForHR(hr);

                    if (cbData == 0)
                    {
                        break; // End of file.
                    }

                    // Send the data to the ASF splitter.
                    hr = pSplitter.ParseData(pBuffer, 0, 0);
                    MFError.ThrowExceptionForHR(hr);

                    // Pull samples from the splitter.
                    do
                    {
                        hr = pSplitter.GetNextSample(out dwStatus, out wStreamID, out pSample);
                        MFError.ThrowExceptionForHR(hr);

                        if (pSample == null)
                        {
                            // No samples yet. Parse more data.
                            break;
                        }

                        try
                        {
                            // We received a sample from the splitter. Check to see
                            // if it's a key frame. The default is FALSE.
                            try
                            {
                                int i;
                                hr = pSample.GetUINT32(MFAttributesClsid.MFSampleExtension_CleanPoint, out i);
                                MFError.ThrowExceptionForHR(hr);
                                bIsKeyFrame = i != 0;
                            }
                            catch
                            {
                                bIsKeyFrame = false;
                            }

                            if (bIsKeyFrame)
                            {
                                // Print various information about the key frame.
                                hr = pSample.GetBufferCount(out cBuffers);
                                MFError.ThrowExceptionForHR(hr);
                                hr = pSample.GetTotalLength(out cbTotalLength);
                                MFError.ThrowExceptionForHR(hr);

                                //Console.WriteLine(string.Format("Buffer count: {0}", cBuffers));
                                //Console.WriteLine(string.Format("Length: {0} bytes", cbTotalLength));

                                hr = pSample.GetSampleTime(out hnsTime);
                                MFError.ThrowExceptionForHR(hr);

                                // Convert the time stamp to seconds.
                                double sec = (double)(hnsTime / 10000) / 1000;

                                //Console.WriteLine(string.Format("Time stamp: {0} sec.", sec));
                            }
                        }
                        finally
                        {
                            COMBase.SafeRelease(pSample);
                        }

                    } while ((dwStatus & ASFStatusFlags.Incomplete) > 0);
                }
                finally
                {
                    COMBase.SafeRelease(pBuffer);
                }
            }
        }
    }

    
}
