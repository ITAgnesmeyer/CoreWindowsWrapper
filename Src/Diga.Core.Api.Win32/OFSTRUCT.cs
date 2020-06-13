using System.Runtime.InteropServices;

// ReSharper disable IdentifierTypo
// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct OFSTRUCT
    {

        /// BYTE->unsigned char
        public byte cBytes;

        /// BYTE->unsigned char
        public byte fFixedDisk;

        /// WORD->unsigned short
        public ushort nErrCode;

        /// WORD->unsigned short
        public ushort Reserved1;

        /// WORD->unsigned short
        public ushort Reserved2;

        /// CHAR[128]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string szPathName;
    }
}