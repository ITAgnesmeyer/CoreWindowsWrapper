using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagFUNCDESC
    {
        /// MEMBERID->DISPID->LONG->int
        public int memid;

        /// SCODE*
        public IntPtr lprgscode;

        /// ELEMDESC*
        public IntPtr lprgelemdescParam;

        /// FUNCKIND->tagFUNCKIND
        public tagFUNCKIND funckind;

        /// INVOKEKIND->tagINVOKEKIND
        public tagINVOKEKIND invkind;

        /// CALLCONV->tagCALLCONV
        public tagCALLCONV callconv;

        /// SHORT->short
        public short cParams;

        /// SHORT->short
        public short cParamsOpt;

        /// SHORT->short
        public short oVft;

        /// SHORT->short
        public short cScodes;

        /// ELEMDESC->tagELEMDESC
        public tagELEMDESC elemdescFunc;

        /// WORD->unsigned short
        public ushort wFuncFlags;
    }
}