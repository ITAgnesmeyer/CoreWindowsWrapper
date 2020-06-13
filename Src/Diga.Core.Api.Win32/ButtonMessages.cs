// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    public static class ButtonMessages
    {
        public const uint BN_CLICKED = 0;
        public const uint BN_PAINT = 1;
        public const uint BN_HILITE = 2;
        public const uint BN_UNHILITE = 3;
        public const uint BN_DISABLE = 4;
        public const uint BN_DOUBLECLICKED = 5;

        public const uint BN_PUSHED = BN_HILITE;
        public const uint BN_UNPUSHED = BN_UNHILITE;
        public const uint BN_DBLCLK = BN_DOUBLECLICKED;
        public const uint BN_SETFOCUS = 6;
        public const uint BN_KILLFOCUS = 7;
    }
}