using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagVARDESC
    {
        /// MEMBERID->DISPID->LONG->int
        public int memid;

        /// LPOLESTR->OLECHAR*
        [MarshalAs(UnmanagedType.LPWStr)]
        public string lpstrSchema;

        /// Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d
        public Anonymous_62e38fe9_336a_4989_8fc3_091f25ee1b7d Union1;

        /// ELEMDESC->tagELEMDESC
        public tagELEMDESC elemdescVar;

        /// WORD->unsigned short
        public ushort wVarFlags;

        /// VARKIND->tagVARKIND
        public tagVARKIND varkind;
    }
}