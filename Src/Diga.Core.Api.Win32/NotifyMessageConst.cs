namespace Diga.Core.Api.Win32
{
    public static class NotifyMessageConst
    {
        public const uint NM_FIRST = unchecked(0U - 0U);
        public const uint NM_OUTOFMEMORY = unchecked(NM_FIRST - 1);
        public const uint NM_CLICK = unchecked(NM_FIRST - 2);
        public const uint NM_DBLCLK = unchecked(NM_FIRST - 3);
        public const uint NM_RETURN = unchecked(NM_FIRST - 4);
        public const uint NM_RCLICK = unchecked(NM_FIRST - 5);
        public const uint NM_RDBLCLK = unchecked(NM_FIRST - 6);
        public const uint NM_SETFOCUS = unchecked(NM_FIRST - 7);
        public const uint NM_KILLFOCUS = unchecked(NM_FIRST - 8);
        public const uint NM_CUSTOMDRAW = unchecked(NM_FIRST - 12);
        public const uint NM_HOVER = unchecked(NM_FIRST - 13);
        public const uint NM_NCHITTEST = unchecked(NM_FIRST - 14);
        public const uint NM_KEYDOWN = unchecked(NM_FIRST - 15);
        public const uint NM_RELEASEDCAPTURE = unchecked(NM_FIRST - 16);
        public const uint NM_SETCURSOR = unchecked(NM_FIRST - 17);
        public const uint NM_CHAR = unchecked(NM_FIRST - 18);
        public const uint NM_TOOLTIPSCREATED = unchecked(NM_FIRST - 19);
        public const uint NM_LAST = unchecked(NM_FIRST - 99);

    }
}