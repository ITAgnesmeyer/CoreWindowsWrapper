using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct LARGE_INTEGER
    {
        /// Anonymous_9320654f_2227_43bf_a385_74cc8c562686
        [FieldOffset(0)]
        public Anonymous_9320654f_2227_43bf_a385_74cc8c562686 Struct1;

        /// Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9
        [FieldOffset(0)]
        public Anonymous_947eb392_1446_4e25_bbd4_10e98165f3a9 u;

        /// LONGLONG->__int64
        [FieldOffset(0)]
        public long QuadPart;
    }
}