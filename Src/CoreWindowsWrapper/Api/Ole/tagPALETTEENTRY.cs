using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPALETTEENTRY
    {
        /// BYTE->unsigned char
        public byte peRed;

        /// BYTE->unsigned char
        public byte peGreen;

        /// BYTE->unsigned char
        public byte peBlue;

        /// BYTE->unsigned char
        public byte peFlags;
    }
}