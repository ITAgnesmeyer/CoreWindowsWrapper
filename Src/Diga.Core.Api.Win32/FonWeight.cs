// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public static class FontWeight
    {
        /// FW_ULTRALIGHT -> FW_EXTRALIGHT
        public const int FW_ULTRALIGHT = FW_EXTRALIGHT;

        /// FW_EXTRALIGHT -> 200
        public const int FW_EXTRALIGHT = 200;

        /// FW_ULTRABOLD -> FW_EXTRABOLD
        public const int FW_ULTRABOLD = FW_EXTRABOLD;

        /// FW_EXTRABOLD -> 800
        public const int FW_EXTRABOLD = 800;

        /// FW_SEMIBOLD -> 600
        public const int FW_SEMIBOLD = 600;

        /// FW_DONTCARE -> 0
        public const int FW_DONTCARE = 0;

        /// FW_DEMIBOLD -> FW_SEMIBOLD
        public const int FW_DEMIBOLD = FW_SEMIBOLD;

        /// FW_REGULAR -> FW_NORMAL
        public const int FW_REGULAR = FW_NORMAL;

        /// FW_NORMAL -> 400
        public const int FW_NORMAL = 400;

        /// FW_MEDIUM -> 500
        public const int FW_MEDIUM = 500;

        /// FW_LIGHT -> 300
        public const int FW_LIGHT = 300;

        /// FW_HEAVY -> 900
        public const int FW_HEAVY = 900;

        /// FW_BLACK -> FW_HEAVY
        public const int FW_BLACK = FW_HEAVY;

        /// FW_THIN -> 100
        public const int FW_THIN = 100;

        /// FW_BOLD -> 700
        public const int FW_BOLD = 700;
    }
}