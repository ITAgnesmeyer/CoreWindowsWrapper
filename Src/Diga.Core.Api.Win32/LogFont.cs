using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public struct LogFont
    {
        /// LONG->int
        public int lfHeight;

        /// LONG->int
        public int lfWidth;

        /// LONG->int
        public int lfEscapement;

        /// LONG->int
        public int lfOrientation;

        /// LONG->int
        public int lfWeight;

        /// BYTE->unsigned char
        public byte lfItalic;

        /// BYTE->unsigned char
        public byte lfUnderline;

        /// BYTE->unsigned char
        public byte lfStrikeOut;

        /// BYTE->unsigned char
        public byte lfCharSet;

        /// BYTE->unsigned char
        public byte lfOutPrecision;

        /// BYTE->unsigned char
        public byte lfClipPrecision;

        /// BYTE->unsigned char
        public byte lfQuality;

        /// BYTE->unsigned char
        public byte lfPitchAndFamily;

        /// WCHAR[32]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string lfFaceName;
    }
}