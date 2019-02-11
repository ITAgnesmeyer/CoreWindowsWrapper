using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct n2
    {
        /// VARTYPE->unsigned short
        public ushort vt;

        /// WORD->unsigned short
        public ushort wReserved1;

        /// WORD->unsigned short
        public ushort wReserved2;

        /// WORD->unsigned short
        public ushort wReserved3;

        /// Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84
        public Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84 n3;
    }
}