using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ULARGE_INTEGER
    {
        /// Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157
        [FieldOffset(0)]
        public Anonymous_652f900e_e9d5_4a81_ba95_5c3af2ba5157 Struct1;

        /// Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a
        [FieldOffset(0)]
        public Anonymous_da3d5bb2_d7f6_4b49_a86f_df044e26e59a u;

        /// ULONGLONG->unsigned __int64
        [FieldOffset(0)]
        public ulong QuadPart;
    }
}