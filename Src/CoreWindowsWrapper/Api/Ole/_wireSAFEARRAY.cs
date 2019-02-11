using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _wireSAFEARRAY
    {
        /// USHORT->unsigned short
        public ushort cDims;

        /// USHORT->unsigned short
        public ushort fFeatures;

        /// ULONG->unsigned int
        public uint cbElements;

        /// ULONG->unsigned int
        public uint cLocks;

        /// SAFEARRAYUNION->_wireSAFEARRAY_UNION
        public SAFEARRAYUNION uArrayStructs;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgsabound;
    }
}