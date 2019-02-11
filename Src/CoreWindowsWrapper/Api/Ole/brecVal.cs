using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct brecVal
    {
        /// PVOID->void*
        public IntPtr pvRecord;

        /// IRecordInfo*
        public IntPtr pRecInfo;
    }
}