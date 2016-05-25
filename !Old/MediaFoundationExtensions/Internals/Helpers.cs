using MediaFoundation.Misc;
using MediaFoundation.Misc.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MediaFoundation.Internals
{
    internal class Helpers
    {
        private const String KERNEL32 = "kernel32.dll";

        [DllImport(KERNEL32, CharSet = CharSet.Auto, BestFitMapping = true)]
        private static extern int FormatMessage(int dwFlags, IntPtr lpSource,
                    int dwMessageId, int dwLanguageId, [Out]StringBuilder lpBuffer,
                    int nSize, IntPtr va_list_arguments);

        private const int FORMAT_MESSAGE_IGNORE_INSERTS = 0x00000200;
        private const int FORMAT_MESSAGE_FROM_SYSTEM = 0x00001000;
        private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 0x00002000;

        // Gets an error message for a Win32 error code.
        public static string GetMessage(int errorCode)
        {
            string errorText = MFError.GetErrorText(errorCode);
            if (!String.IsNullOrWhiteSpace(errorText))
                return errorText;

            StringBuilder sb = new StringBuilder(512);
            int result = Helpers.FormatMessage(
                    FORMAT_MESSAGE_IGNORE_INSERTS | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_ARGUMENT_ARRAY,
                    IntPtr.Zero, errorCode, 0, sb, sb.Capacity, IntPtr.Zero);
            if (result != 0)
            {
                // result is the # of characters copied to the StringBuilder.
                return sb.ToString();
            }
            else
            {
                return String.Format("Error: {0} (0x{0:X8})", errorCode);
            }
        }
    }
}
