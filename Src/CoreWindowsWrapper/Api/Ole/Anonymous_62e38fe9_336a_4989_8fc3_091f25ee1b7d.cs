using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d
    {
        /// ULONG->unsigned int
        [FieldOffset(0)]
        public uint oInst;

        /// VARIANT*
        [FieldOffset(0)]
        public IntPtr lpvarValue;
    }
}