using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPARAMDESCEX
    {
        /// ULONG->unsigned int
        public uint cBytes;

        /// VARIANTARG->VARIANT->tagVARIANT
        public tagVARIANT varDefaultValue;
    }
}