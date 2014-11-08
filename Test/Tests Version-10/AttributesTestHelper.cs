using MediaFoundation;
using MediaFoundation.Misc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestsVersion_10
{
    public static class AttributesTestHelper
    {
        public static void TestAll(IMFAttributes attributes)
        {
            AttributesTestHelper.TestGetUINT32(attributes);
            AttributesTestHelper.TestGetUINT64(attributes);
            AttributesTestHelper.TestGetDouble(attributes);
            AttributesTestHelper.TestGetGuid(attributes);
            AttributesTestHelper.TestGetString(attributes);
            AttributesTestHelper.TestGetAllocatedString(attributes);
            AttributesTestHelper.TestGetUnknown(attributes);
            AttributesTestHelper.TestGetAllocatedBlob(attributes);
            AttributesTestHelper.TestGetBlob(attributes);
            AttributesTestHelper.TestGetItem(attributes);

            AttributesTestHelper.TestCopyAllItems(attributes);

            AttributesTestHelper.TestGetItemByIndex(attributes);

            AttributesTestHelper.TestLockStore(attributes);
        }

        public static void TestGetItem(IMFAttributes attributes)
        {
            PropVariant o2;
            byte[] b = { 1, 2, 3 };
            byte[] b2;

            o2 = TestGetItem2(attributes, new PropVariant("asdf"));
            Assert.AreEqual("asdf", o2.GetString());

            o2 = TestGetItem2(attributes, new PropVariant((uint)13));
            Assert.AreEqual((uint)13, o2.GetUInt());

            o2 = TestGetItem2(attributes, new PropVariant(5.5));
            Assert.AreEqual(5.5, o2.GetDouble());

            o2 = TestGetItem2(attributes, new PropVariant((ulong)0x1234567890ABCDEFL));
            Assert.AreEqual((ulong)0x1234567890ABCDEFL, o2.GetULong());

            o2 = TestGetItem2(attributes, new PropVariant(typeof(IMFAttributes).GUID));
            Assert.AreEqual(typeof(IMFAttributes).GUID, o2.GetGuid());

            o2 = TestGetItem2(attributes, new PropVariant(b));
            b2 = o2.GetBlob();
            CollectionAssert.AreEqual(b, b2);

            object marker = new object();
            o2 = TestGetItem2(attributes, new PropVariant(marker));
            Assert.AreSame(marker, o2.GetIUnknown());
        }

        private static PropVariant TestGetItem2(IMFAttributes attributes, PropVariant o)
        {
            MFAttributeType pType;
            PropVariant o2 = new PropVariant();

            Guid g = Guid.NewGuid();
            int hr;
            hr = attributes.SetItem(g, o);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetItem(g, o2);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetItemType(g, out pType);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(o.GetMFAttributeType(), o2.GetMFAttributeType());
            Assert.AreEqual(o2.GetMFAttributeType(), pType);

            return o2;
        }

        public static void TestGetUINT32(IMFAttributes attributes)
        {
            int i;
            Guid g = Guid.NewGuid();
            int hr = attributes.SetUINT32(g, 3);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetUINT32(g, out i);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(3, i);
        }

        public static void TestGetUINT64(IMFAttributes attributes)
        {
            long l;
            Guid g = Guid.NewGuid();
            int hr = attributes.SetUINT64(g, 0x1234567890ABCDEFL);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetUINT64(g, out l);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(0x1234567890ABCDEFL, l);
        }

        public static void TestGetDouble(IMFAttributes attributes)
        {
            double d;
            Guid g = Guid.NewGuid();
            int hr = attributes.SetDouble(g, 5.5);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetDouble(g, out d);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(5.5, d);
        }

        public static void TestGetGuid(IMFAttributes attributes)
        {
            Guid gv1, gv2;
            Guid g = Guid.NewGuid();
            gv1 = Guid.NewGuid();
            int hr = attributes.SetGUID(g, gv1);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetGUID(g, out gv2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(gv1, gv2);
        }

        public static void TestGetString(IMFAttributes attributes)
        {
            int c;
            int c2;
            Guid g = Guid.NewGuid();
            StringBuilder s;

            int hr = attributes.SetString(g, "hey");
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetStringLength(g, out c);
            MFError.ThrowExceptionForHR(hr);
            Assert.AreEqual(3, c);

            s = new StringBuilder(c + 1);
            hr = attributes.GetString(g, s, s.Capacity, out c2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(3, c2);
            Assert.AreEqual("hey", s.ToString());
        }

        public static void TestGetAllocatedString(IMFAttributes attributes)
        {
            int c;
            Guid g = Guid.NewGuid();
            string s;

            int hr = attributes.SetString(g, "hey there");
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetAllocatedString(g, out s, out c);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(9, c);
            Assert.AreEqual("hey there", s);
        }

        public static void TestGetBlob(IMFAttributes attributes)
        {
            int c, c2;
            Guid g = Guid.NewGuid();
            byte[] b = new byte[33];
            byte[] b2;

            for (int x = 13; x < b.Length + 13; x++)
            {
                b[x - 13] = (byte)x;
            }

            int hr = attributes.SetBlob(g, b, b.Length);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetBlobSize(g, out c);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(b.Length, c);

            b2 = new byte[c];

            hr = attributes.GetBlob(g, b2, c, out c2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(c, c2);
            CollectionAssert.AreEqual(b, b2);
        }

        public static void TestGetAllocatedBlob(IMFAttributes attributes)
        {
            int c, c2;
            Guid g = Guid.NewGuid();
            byte[] b = new byte[33];
            byte[] b2;

            for (int x = 13; x < b.Length + 13; x++)
            {
                b[x - 13] = (byte)x;
            }

            int hr = attributes.SetBlob(g, b, b.Length);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetBlobSize(g, out c);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(b.Length, c);

            IntPtr ip = IntPtr.Zero;

            hr = attributes.GetAllocatedBlob(g, out ip, out c2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(b.Length, c2);
            Assert.AreNotEqual(IntPtr.Zero, ip);

            b2 = new byte[c2];
            Marshal.Copy(ip, b2, 0, c2);
            Marshal.FreeCoTaskMem(ip);

            CollectionAssert.AreEqual(b, b2);
        }

        public static void TestGetUnknown(IMFAttributes attributes)
        {
            Guid g = Guid.NewGuid();
            object o;
            Guid IID = new Guid("00000000-0000-0000-C000-000000000046");

            int hr = attributes.SetUnknown(g, attributes);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.GetUnknown(g, IID, out o);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(attributes, o);
        }

        public static void TestLockStore(IMFAttributes attributes)
        {
            int hr = attributes.LockStore();
            MFError.ThrowExceptionForHR(hr);
            hr = attributes.UnlockStore();
            MFError.ThrowExceptionForHR(hr);
        }

        public static void TestGetItemByIndex(IMFAttributes attributes)
        {
            Guid g;
            PropVariant o = new PropVariant();
            int iCnt1, iCnt2;
            bool bRes;

            int hr = attributes.GetCount(out iCnt1);
            MFError.ThrowExceptionForHR(hr);

            // Must ensure that there is at least 1 attribute. The test below adds it
            if (iCnt1 == 0)
            {
                AttributesTestHelper.TestGetUINT32(attributes);

                // Requiery the count.
                hr = attributes.GetCount(out iCnt1);
                MFError.ThrowExceptionForHR(hr);
            }

            Assert.IsTrue(iCnt1 > 0);

            hr = attributes.GetItemByIndex(0, out g, o);
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.CompareItem(g, o, out bRes);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(bRes);

            hr = attributes.DeleteItem(g);
            MFError.ThrowExceptionForHR(hr);
            hr = attributes.GetCount(out iCnt2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(iCnt1 - 1, iCnt2);
        }

        public static void TestCopyAllItems(IMFAttributes attributes)
        {
            IMFAttributes copy;
            int iCnt1, iCnt2;
            bool bRes;

            int hr = attributes.GetCount(out iCnt1);
            MFError.ThrowExceptionForHR(hr);

            // Must ensure that there is at least 1 attribute. The test below adds it
            if (iCnt1 == 0)
            {
                AttributesTestHelper.TestGetUINT32(attributes);

                // Requiery the count.
                hr = attributes.GetCount(out iCnt1);
                MFError.ThrowExceptionForHR(hr);
            }

            Assert.IsTrue(iCnt1 > 0);

            hr = MFExtern.MFCreateAttributes(out copy, 20);
            MFError.ThrowExceptionForHR(hr);

            Assert.IsNotNull(copy);

            hr = attributes.CopyAllItems(copy);
            MFError.ThrowExceptionForHR(hr);
            hr = copy.GetCount(out iCnt2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(iCnt1, iCnt2);

            hr = attributes.Compare(copy, MFAttributesMatchType.AllItems, out bRes);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsTrue(bRes);

            hr = copy.DeleteAllItems();
            MFError.ThrowExceptionForHR(hr);

            hr = attributes.Compare(copy, MFAttributesMatchType.AllItems, out bRes);
            MFError.ThrowExceptionForHR(hr);
            Assert.IsFalse(bRes);

            hr = copy.GetCount(out iCnt2);
            MFError.ThrowExceptionForHR(hr);

            Assert.AreEqual(0, iCnt2);
        }
    }
}
