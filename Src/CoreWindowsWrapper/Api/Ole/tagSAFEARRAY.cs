using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAY
    {
        /// USHORT->unsigned short
        public ushort cDims;

        /// USHORT->unsigned short
        public ushort fFeatures;

        /// ULONG->unsigned int
        public uint cbElements;

        /// ULONG->unsigned int
        public uint cLocks;

        /// PVOID->void*
        public IntPtr pvData;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgsabound;
    }
}