namespace Diga.Core.Api.Win32
{
    public static class ListBoxStyle
    {
        /// LBS_WANTKEYBOARDINPUT -> 0x0400L
        public const uint LBS_WANTKEYBOARDINPUT = 1024;
    
        /// LBS_OWNERDRAWVARIABLE -> 0x0020L
        public const uint LBS_OWNERDRAWVARIABLE = 32;
    
        /// LBS_NOINTEGRALHEIGHT -> 0x0100L
        public const uint LBS_NOINTEGRALHEIGHT = 256;
    
        /// LBS_DISABLENOSCROLL -> 0x1000L
        public const uint LBS_DISABLENOSCROLL = 4096;
    
        /// LBS_OWNERDRAWFIXED -> 0x0010L
        public const uint LBS_OWNERDRAWFIXED = 16;
    
        /// LBS_USETABSTOPS -> 0x0080L
        public const uint LBS_USETABSTOPS = 128;
    
        /// LBS_MULTIPLESEL -> 0x0008L
        public const uint LBS_MULTIPLESEL = 8;
    
        /// LBS_MULTICOLUMN -> 0x0200L
        public const uint LBS_MULTICOLUMN = 512;
    
        /// LBS_EXTENDEDSEL -> 0x0800L
        public const uint LBS_EXTENDEDSEL = 2048;
    
        /// LBS_HASSTRINGS -> 0x0040L
        public const uint LBS_HASSTRINGS = 64;
    
        /// LBS_STANDARD -> (LBS_NOTIFY | LBS_SORT | WS_VSCROLL | WS_BORDER)
        public const uint LBS_STANDARD = LBS_NOTIFY | LBS_SORT | WindowStylesConst.WS_VSCROLL | WindowStylesConst.WS_BORDER;
    
        /// LBS_NOREDRAW -> 0x0004L
        public const uint LBS_NOREDRAW = 4;
    
        /// LBS_COMBOBOX -> 0x8000L
        public const uint LBS_COMBOBOX = 32768;
    
        /// LBS_NOTIFY -> 0x0001L
        public const uint LBS_NOTIFY = 1;
    
        /// LBS_NODATA -> 0x2000L
        public const uint LBS_NODATA = 8192;
    
        /// LBS_NOSEL -> 0x4000L
        public const uint LBS_NOSEL = 16384;
    
        /// LBS_SORT -> 0x0002L
        public const uint LBS_SORT = 2;

    }
}