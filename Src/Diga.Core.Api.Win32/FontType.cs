// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public static class FontType
    {
        /// SIMULATED_FONTTYPE -> 0x8000
        public const int SIMULATED_FONTTYPE = 32768;

        /// TRUETYPE_FONTTYPE -> 0x004
        public const int TRUETYPE_FONTTYPE = 4;

        /// REGULAR_FONTTYPE -> 0x0400
        public const int REGULAR_FONTTYPE = 1024;

        /// PRINTER_FONTTYPE -> 0x4000
        public const int PRINTER_FONTTYPE = 16384;

        /// SCREEN_FONTTYPE -> 0x2000
        public const int SCREEN_FONTTYPE = 8192;

        /// RASTER_FONTTYPE -> 0x0001
        public const int RASTER_FONTTYPE = 1;

        /// ITALIC_FONTTYPE -> 0x0200
        public const int ITALIC_FONTTYPE = 512;

        /// DEVICE_FONTTYPE -> 0x002
        public const int DEVICE_FONTTYPE = 2;

        /// BOLD_FONTTYPE -> 0x0100
        public const int BOLD_FONTTYPE = 256;
    }
}