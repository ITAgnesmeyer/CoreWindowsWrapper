using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct _wireVARIANT
    {
        /// DWORD->unsigned int
        public uint clSize;

        /// DWORD->unsigned int
        public uint rpcReserved;

        /// USHORT->unsigned short
        public ushort vt;

        /// USHORT->unsigned short
        public ushort wReserved1;

        /// USHORT->unsigned short
        public ushort wReserved2;

        /// USHORT->unsigned short
        public ushort wReserved3;

        /// Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172
        public Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172 Union1;
    }
}