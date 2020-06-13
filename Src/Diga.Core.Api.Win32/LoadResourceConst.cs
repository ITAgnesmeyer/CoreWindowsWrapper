// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public class LoadResourceConst
    {
        /// LR_CREATEDIBSECTION -> 0x2000
        public const int LR_CREATEDIBSECTION = 8192;

        /// LR_COPYFROMRESOURCE -> 0x4000
        public const int LR_COPYFROMRESOURCE = 16384;

        /// LR_LOADTRANSPARENT -> 0x0020
        public const int LR_LOADTRANSPARENT = 32;

        /// LR_LOADMAP3DCOLORS -> 0x1000
        public const int LR_LOADMAP3DCOLORS = 4096;

        /// LR_COPYRETURNORG -> 0x0004
        public const int LR_COPYRETURNORG = 4;

        /// LR_COPYDELETEORG -> 0x0008
        public const int LR_COPYDELETEORG = 8;

        /// LR_LOADFROMFILE -> 0x0010
        public const int LR_LOADFROMFILE = 16;

        /// LR_DEFAULTCOLOR -> 0x0000
        public const int LR_DEFAULTCOLOR = 0;

        /// LR_DEFAULTSIZE -> 0x0040
        public const int LR_DEFAULTSIZE = 64;

        /// LR_MONOCHROME -> 0x0001
        public const int LR_MONOCHROME = 1;

        /// LR_VGACOLOR -> 0x0080
        public const int LR_VGACOLOR = 128;

        /// LR_SHARED -> 0x8000
        public const int LR_SHARED = 32768;

        /// LR_COLOR -> 0x0002
        public const int LR_COLOR = 2;
    }
}