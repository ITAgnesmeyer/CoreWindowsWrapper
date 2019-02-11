using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CHAR_INFO
    {
        /// Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d
        public Anonymous_f3630dcb_df39_4f30_a593_48e610e9363d Char;

        /// WORD->unsigned short
        public ushort Attributes;
    }
}