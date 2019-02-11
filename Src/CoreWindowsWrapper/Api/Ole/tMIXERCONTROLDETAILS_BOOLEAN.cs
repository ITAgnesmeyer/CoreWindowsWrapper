using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tMIXERCONTROLDETAILS_BOOLEAN
    {
        /// LONG->int
        public int fValue;
    }
}