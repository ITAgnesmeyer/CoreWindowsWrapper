using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagARRAYDESC
    {
        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdescElem;

        /// USHORT->unsigned short
        public ushort cDims;

        /// SAFEARRAYBOUND[1]
        [MarshalAs(UnmanagedType.ByValArray,
            SizeConst = 1, ArraySubType = UnmanagedType.Struct)]
        public tagSAFEARRAYBOUND[] rgbounds;
    }
}