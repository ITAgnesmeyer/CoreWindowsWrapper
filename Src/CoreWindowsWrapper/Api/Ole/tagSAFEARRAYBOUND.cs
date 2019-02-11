using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSAFEARRAYBOUND
    {
        /// ULONG->unsigned int
        public uint cElements;

        /// LONG->int
        public int lLbound;
    }
}