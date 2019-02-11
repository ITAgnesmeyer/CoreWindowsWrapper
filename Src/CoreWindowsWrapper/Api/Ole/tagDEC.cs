using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagDEC
    {
        /// USHORT->unsigned short
        public ushort wReserved;

        /// Anonymous_8abb5787_2644_417f_a055_f230370c6002
        public Anonymous_8abb5787_2644_417f_a055_f230370c6002 Union1;

        /// ULONG->unsigned int
        public uint Hi32;

        /// Anonymous_f95820c2_86d5_4678_8973_0d686c1da512
        public Anonymous_f95820c2_86d5_4678_8973_0d686c1da512 Union2;
    }
}