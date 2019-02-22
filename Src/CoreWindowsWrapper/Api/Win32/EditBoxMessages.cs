// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Win32
{
    internal static class EditBoxMessages
    {
        public const uint EN_SETFOCUS = 0x0100;
        public const uint EN_KILLFOCUS = 0x0200;
        public const uint EN_CHANGE = 0x0300;
        public const uint EN_UPDATE = 0x0400;
        public const uint EN_ERRSPACE = 0x0500;
        public const uint EN_MAXTEXT = 0x0501;
        public const uint EN_HSCROLL = 0x0601;
        public const uint EN_VSCROLL = 0x0602;
        public const uint EN_ALIGN_LTR_EC = 0x0700;
        public const uint EN_ALIGN_RTL_EC = 0x0701;
        public const uint EN_BEFORE_PASTE = 0x0800;
        public const uint EN_AFTER_PASTE = 0x0801;

        /// EM_GETFIRSTVISIBLELINE -> 0x00CE
        public const int EM_GETFIRSTVISIBLELINE = 206;

        /// EM_SETWORDBREAKPROC -> 0x00D0
        public const int EM_SETWORDBREAKPROC = 208;

        /// EM_GETWORDBREAKPROC -> 0x00D1
        public const int EM_GETWORDBREAKPROC = 209;

        /// EM_SETPASSWORDCHAR -> 0x00CC
        public const int EM_SETPASSWORDCHAR = 204;

        /// EM_GETPASSWORDCHAR -> 0x00D2
        public const int EM_GETPASSWORDCHAR = 210;

        /// EM_EMPTYUNDOBUFFER -> 0x00CD
        public const int EM_EMPTYUNDOBUFFER = 205;

        /// EM_SETLIMITTEXT -> EM_LIMITTEXT
        public const int EM_SETLIMITTEXT = EM_LIMITTEXT;

        /// EM_SETIMESTATUS -> 0x00D8
        public const int EM_SETIMESTATUS = 216;

        /// EM_LINEFROMCHAR -> 0x00C9
        public const int EM_LINEFROMCHAR = 201;

        /// EM_GETLINECOUNT -> 0x00BA
        public const int EM_GETLINECOUNT = 186;

        /// EM_GETLIMITTEXT -> 0x00D5
        public const int EM_GETLIMITTEXT = 213;

        /// EM_GETIMESTATUS -> 0x00D9
        public const int EM_GETIMESTATUS = 217;

        /// EM_SETTABSTOPS -> 0x00CB
        public const int EM_SETTABSTOPS = 203;

        /// EM_SETREADONLY -> 0x00CF
        public const int EM_SETREADONLY = 207;

        /// EM_SCROLLCARET -> 0x00B7
        public const int EM_SCROLLCARET = 183;

        /// EM_POSFROMCHAR -> 0x00D6
        public const int EM_POSFROMCHAR = 214;

        /// EM_CHARFROMPOS -> 0x00D7
        public const int EM_CHARFROMPOS = 215;

        /// EM_SETMARGINS -> 0x00D3
        public const int EM_SETMARGINS = 211;

        /// EM_REPLACESEL -> 0x00C2
        public const int EM_REPLACESEL = 194;

        /// EM_LINESCROLL -> 0x00B6
        public const int EM_LINESCROLL = 182;

        /// EM_LINELENGTH -> 0x00C1
        public const int EM_LINELENGTH = 193;

        /// EM_GETMARGINS -> 0x00D4
        public const int EM_GETMARGINS = 212;

        /// EM_SETRECTNP -> 0x00B4
        public const int EM_SETRECTNP = 180;

        /// EM_SETMODIFY -> 0x00B9
        public const int EM_SETMODIFY = 185;

        /// EM_SETHANDLE -> 0x00BC
        public const int EM_SETHANDLE = 188;

        /// EM_LINEINDEX -> 0x00BB
        public const int EM_LINEINDEX = 187;

        /// EM_LIMITTEXT -> 0x00C5
        public const int EM_LIMITTEXT = 197;

        /// EM_GETMODIFY -> 0x00B8
        public const int EM_GETMODIFY = 184;

        /// EM_GETHANDLE -> 0x00BD
        public const int EM_GETHANDLE = 189;

        /// EM_GETTHUMB -> 0x00BE
        public const int EM_GETTHUMB = 190;

        /// EM_FMTLINES -> 0x00C8
        public const int EM_FMTLINES = 200;

        /// EM_SETRECT -> 0x00B3
        public const int EM_SETRECT = 179;

        /// EM_GETRECT -> 0x00B2
        public const int EM_GETRECT = 178;

        /// EM_GETLINE -> 0x00C4
        public const int EM_GETLINE = 196;

        /// EM_CANUNDO -> 0x00C6
        public const int EM_CANUNDO = 198;

        /// EM_SETSEL -> 0x00B1
        public const int EM_SETSEL = 177;

        /// EM_SCROLL -> 0x00B5
        public const int EM_SCROLL = 181;

        /// EM_GETSEL -> 0x00B0
        public const int EM_GETSEL = 176;

        /// EM_UNDO -> 0x00C7
        public const int EM_UNDO = 199;
    }

    internal static class RichEditMessages
    {
        public const int WM_CONTEXTMENU = 123;
        public const int WM_UNICHAR = 265;
        public const int WM_PRINTCLIENT = 792;
        public const int EM_GETLIMITTEXT = 1061;
        public const int EM_POSFROMCHAR = 1062;
        public const int EM_CHARFROMPOS = 1063;
        public const int EM_SCROLLCARET = 1073;
        public const int EM_CANPASTE = 1074;
        public const int EM_DISPLAYBAND = 1075;
        public const int EM_EXGETSEL = 1076;
        public const int EM_EXLIMITTEXT = 1077;
        public const int EM_EXLINEFROMCHAR = 1078;
        public const int EM_EXSETSEL = 1079;
        public const int EM_FINDTEXT = 1080;
        public const int EM_FORMATRANGE = 1081;
        public const int EM_GETCHARFORMAT = 1082;
        public const int EM_GETEVENTMASK = 1083;
        public const int EM_GETOLEINTERFACE = 1084;
        public const int EM_GETPARAFORMAT = 1085;
        public const int EM_GETSELTEXT = 1086;
        public const int EM_HIDESELECTION = 1087;
        public const int EM_PASTESPECIAL = 1088;
        public const int EM_REQUESTRESIZE = 1089;
        public const int EM_SELECTIONTYPE = 1090;
        public const int EM_SETBKGNDCOLOR = 1091;
        public const int EM_SETCHARFORMAT = 1092;
        public const int EM_SETEVENTMASK = 1093;
        public const int EM_SETOLECALLBACK = 1094;
        public const int EM_SETPARAFORMAT = 1095;
        public const int EM_SETTARGETDEVICE = 1096;
        public const int EM_STREAMIN = 1097;
        public const int EM_STREAMOUT = 1098;
        public const int EM_GETTEXTRANGE = 1099;
        public const int EM_FINDWORDBREAK = 1100;
        public const int EM_SETOPTIONS = 1101;
        public const int EM_GETOPTIONS = 1102;
        public const int EM_FINDTEXTEX = 1103;
        public const int EM_GETWORDBREAKPROCEX = 1104;
        public const int EM_SETWORDBREAKPROCEX = 1105;
        public const int EM_SETUNDOLIMIT = 1106;
        public const int EM_REDO = 1108;
        public const int EM_CANREDO = 1109;
        public const int EM_GETUNDONAME = 1110;
        public const int EM_GETREDONAME = 1111;
        public const int EM_STOPGROUPTYPING = 1112;
        public const int EM_SETTEXTMODE = 1113;
        public const int EM_GETTEXTMODE = 1114;
    }


    internal static class CodepageConst
    {
        public const int CP_ACP = 0;
        public const int CP_OEMCP = 1;
        public const int CP_MACCP = 2;
        public const int CP_THREAD_ACP = 3;
        public const int CP_SYMBOL = 42;
        public const int CP_UTF7 = 65000;
        public const int CP_UTF8 = 65001;
        public const int CP_CONTROLDEFUALT = -1;
        public const int CP_UNICODE = 1200;

    }


    // EM_SETTEXTEX info; this struct is passed in the wparam of the message 
    public class SETTEXTEX
    {
        public uint flags; // Flags (see the ST_XXX defines)
        public uint codepage; // Code page for translation (CP_ACP for sys default,
        //  1200 for Unicode, -1 for control default)	
    }


    // EM_GETTEXTEX info; this struct is passed in the wparam of the message 
    internal class GETTEXTEX
    {
        public uint cb; // Count of bytes in the string
        public uint flags; // Flags (see the GT_XXX defines
        public uint codepage; // Code page for translation (CP_ACP for sys default,
        //  1200 for Unicode, -1 for control default)	
        
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
        public string lpDefaultChar; // Replacement for unmappable chars
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
//ORIGINAL LINE: bool * lpUsedDefChar;
        [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public bool lpUsedDefChar; // Pointer to flag set when def char used
    }

    internal static class RichTextSetTextConst
    {
        public const int ST_DEFAULT = 0;
        public const int ST_KEEPUNDO = 1;
        public const int ST_SELECTION = 2;
        public const int ST_NEWCHARS = 4;

    }

    internal static class RichtTextGetTextConst
    {
        public const int GT_DEFAULT = 0;
        public const int GT_USECRLF = 1;
        public const int GT_SELECTION = 2;
        public const int GT_RAWTEXT = 4;
        public const int GT_NOHIDDENTEXT = 8;
    }

}