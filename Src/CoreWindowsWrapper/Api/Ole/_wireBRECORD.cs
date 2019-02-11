using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _wireBRECORD
    {
        /// ULONG->unsigned int
        public uint fFlags;

        /// ULONG->unsigned int
        public uint clSize;

        /// IRecordInfo*
        public IntPtr pRecInfo;

        /// byte*
        public IntPtr pRecord;
    }
}