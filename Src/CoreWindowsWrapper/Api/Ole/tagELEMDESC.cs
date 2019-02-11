using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagELEMDESC
    {
        /// TYPEDESC->tagTYPEDESC
        public tagTYPEDESC tdesc;

        /// Anonymous_40d14048_0ade_44b7_81ed_baa885f6fcb2
        public Anonymous_40d14048_0ade_44b7_81ed_baa885f6fcb2 Union1;
    }
}