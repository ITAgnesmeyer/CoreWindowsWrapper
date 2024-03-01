using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Diga.Core.Api.Win32;
using Diga.Core.Api.Win32.Com;

namespace CoreWindowsWrapper
{

    public class NativeRichTextBox : NativeControlBase
    {

        private class RichtTextBoxConst
        {
            private const uint WM_USER = WindowsMessages.WM_USER;
            public const uint cchTextLimitDefault = 32767;
            public const uint WM_CONTEXTMENU = 0x007B;
            public const uint WM_UNICHAR = 0x0109;
            public const uint WM_PRINTCLIENT = 0x0318;
            public const uint EM_GETLIMITTEXT = (WM_USER + 37);
            public const uint EM_POSFROMCHAR = (WM_USER + 38);
            public const uint EM_CHARFROMPOS = (WM_USER + 39);
            public const uint EM_SCROLLCARET = (WM_USER + 49);
            public const uint EM_CANPASTE = (WM_USER + 50);
            public const uint EM_DISPLAYBAND = (WM_USER + 51);
            public const uint EM_EXGETSEL = (WM_USER + 52);
            public const uint EM_EXLIMITTEXT = (WM_USER + 53);
            public const uint EM_EXLINEFROMCHAR = (WM_USER + 54);
            public const uint EM_EXSETSEL = (WM_USER + 55);
            public const uint EM_FINDTEXT = (WM_USER + 56);
            public const uint EM_FORMATRANGE = (WM_USER + 57);
            public const uint EM_GETCHARFORMAT = (WM_USER + 58);
            public const uint EM_GETEVENTMASK = (WM_USER + 59);
            public const uint EM_GETOLEINTERFACE = (WM_USER + 60);
            public const uint EM_GETPARAFORMAT = (WM_USER + 61);
            public const uint EM_GETSELTEXT = (WM_USER + 62);
            public const uint EM_HIDESELECTION = (WM_USER + 63);
            public const uint EM_PASTESPECIAL = (WM_USER + 64);
            public const uint EM_REQUESTRESIZE = (WM_USER + 65);
            public const uint EM_SELECTIONTYPE = (WM_USER + 66);
            public const uint EM_SETBKGNDCOLOR = (WM_USER + 67);
            public const uint EM_SETCHARFORMAT = (WM_USER + 68);
            public const uint EM_SETEVENTMASK = (WM_USER + 69);
            public const uint EM_SETOLECALLBACK = (WM_USER + 70);
            public const uint EM_SETPARAFORMAT = (WM_USER + 71);
            public const uint EM_SETTARGETDEVICE = (WM_USER + 72);
            public const uint EM_STREAMIN = (WM_USER + 73);
            public const uint EM_STREAMOUT = (WM_USER + 74);
            public const uint EM_GETTEXTRANGE = (WM_USER + 75);
            public const uint EM_FINDWORDBREAK = (WM_USER + 76);
            public const uint EM_SETOPTIONS = (WM_USER + 77);
            public const uint EM_GETOPTIONS = (WM_USER + 78);
            public const uint EM_FINDTEXTEX = (WM_USER + 79);
            public const uint EM_GETWORDBREAKPROCEX = (WM_USER + 80);
            public const uint EM_SETWORDBREAKPROCEX = (WM_USER + 81);
            public const uint EM_SETUNDOLIMIT = (WM_USER + 82);
            public const uint EM_REDO = (WM_USER + 84);
            public const uint EM_CANREDO = (WM_USER + 85);
            public const uint EM_GETUNDONAME = (WM_USER + 86);
            public const uint EM_GETREDONAME = (WM_USER + 87);
            public const uint EM_STOPGROUPTYPING = (WM_USER + 88);
            public const uint EM_SETTEXTMODE = (WM_USER + 89);
            public const uint EM_GETTEXTMODE = (WM_USER + 90);
            public const uint EM_AUTOURLDETECT = (WM_USER + 91);
            public const uint AURL_ENABLEURL = 1;
            public const uint AURL_ENABLEEMAILADDR = 2;
            public const uint AURL_ENABLETELNO = 4;
            public const uint AURL_ENABLEEAURLS = 8;
            public const uint AURL_ENABLEDRIVELETTERS = 16;
            public const uint AURL_DISABLEMIXEDLGC = 32;// Disable mixed Latin Greek Cyrillic IDNs
            public const uint EM_GETAUTOURLDETECT = (WM_USER + 92);
            public const uint EM_SETPALETTE = (WM_USER + 93);
            public const uint EM_GETTEXTEX = (WM_USER + 94);
            public const uint EM_GETTEXTLENGTHEX = (WM_USER + 95);
            public const uint EM_SHOWSCROLLBAR = (WM_USER + 96);
            public const uint EM_SETTEXTEX = (WM_USER + 97);
            public const uint EM_SETPUNCTUATION = (WM_USER + 100);
            public const uint EM_GETPUNCTUATION = (WM_USER + 101);
            public const uint EM_SETWORDWRAPMODE = (WM_USER + 102);
            public const uint EM_GETWORDWRAPMODE = (WM_USER + 103);
            public const uint EM_SETIMECOLOR = (WM_USER + 104);
            public const uint EM_GETIMECOLOR = (WM_USER + 105);
            public const uint EM_SETIMEOPTIONS = (WM_USER + 106);
            public const uint EM_GETIMEOPTIONS = (WM_USER + 107);
            public const uint EM_CONVPOSITION = (WM_USER + 108);
            public const uint EM_SETLANGOPTIONS = (WM_USER + 120);
            public const uint EM_GETLANGOPTIONS = (WM_USER + 121);
            public const uint EM_GETIMECOMPMODE = (WM_USER + 122);
            public const uint EM_FINDTEXTW = (WM_USER + 123);
            public const uint EM_FINDTEXTEXW = (WM_USER + 124);
            public const uint EM_RECONVERSION = (WM_USER + 125);
            public const uint EM_SETIMEMODEBIAS = (WM_USER + 126);
            public const uint EM_GETIMEMODEBIAS = (WM_USER + 127);
            public const uint EM_SETBIDIOPTIONS = (WM_USER + 200);
            public const uint EM_GETBIDIOPTIONS = (WM_USER + 201);
            public const uint EM_SETTYPOGRAPHYOPTIONS = (WM_USER + 202);
            public const uint EM_GETTYPOGRAPHYOPTIONS = (WM_USER + 203);
            public const uint EM_SETEDITSTYLE = (WM_USER + 204);
            public const uint EM_GETEDITSTYLE = (WM_USER + 205);
            public const uint SES_EMULATESYSEDIT = 1;
            public const uint SES_BEEPONMAXTEXT = 2;
            public const uint SES_EXTENDBACKCOLOR = 4;
            public const uint SES_MAPCPS = 8;// Obsolete (never used)
            public const uint SES_HYPERLINKTOOLTIPS = 8;
            public const uint SES_EMULATE10 = 16;// Obsolete (never used)
            public const uint SES_DEFAULTLATINLIGA = 16;
            public const uint SES_USECRLF = 32;// Obsolete (never used)
            public const uint SES_NOFOCUSLINKNOTIFY = 32;
            public const uint SES_USEAIMM = 64;
            public const uint SES_NOIME = 128;
            public const uint SES_ALLOWBEEPS = 256;
            public const uint SES_UPPERCASE = 512;
            public const uint SES_LOWERCASE = 1024;
            public const uint SES_NOINPUTSEQUENCECHK = 2048;
            public const uint SES_BIDI = 4096;
            public const uint SES_SCROLLONKILLFOCUS = 8192;
            public const uint SES_XLTCRCRLFTOCR = 16384;
            public const uint SES_DRAFTMODE = 32768;
            public const uint SES_USECTF = 0x00010000;
            public const uint SES_HIDEGRIDLINES = 0x00020000;
            public const uint SES_USEATFONT = 0x00040000;
            public const uint SES_CUSTOMLOOK = 0x00080000;
            public const uint SES_LBSCROLLNOTIFY = 0x00100000;
            public const uint SES_CTFALLOWEMBED = 0x00200000;
            public const uint SES_CTFALLOWSMARTTAG = 0x00400000;
            public const uint SES_CTFALLOWPROOFING = 0x00800000;
            public const uint SES_LOGICALCARET = 0x01000000;
            public const uint SES_WORDDRAGDROP = 0x02000000;
            public const uint SES_SMARTDRAGDROP = 0x04000000;
            public const uint SES_MULTISELECT = 0x08000000;
            public const uint SES_CTFNOLOCK = 0x10000000;
            public const uint SES_NOEALINEHEIGHTADJUST = 0x20000000;
            public const uint SES_MAX = 0x20000000;
            public const uint IMF_AUTOKEYBOARD = 0x0001;
            public const uint IMF_AUTOFONT = 0x0002;
            public const uint IMF_IMECANCELCOMPLETE = 0x0004;// High completes comp string when aborting, low cancels
            public const uint IMF_IMEALWAYSSENDNOTIFY = 0x0008;
            public const uint IMF_AUTOFONTSIZEADJUST = 0x0010;
            public const uint IMF_UIFONTS = 0x0020;
            public const uint IMF_NOIMPLICITLANG = 0x0040;
            public const uint IMF_DUALFONT = 0x0080;
            public const uint IMF_NOKBDLIDFIXUP = 0x0200;
            public const uint IMF_NORTFFONTSUBSTITUTE = 0x0400;
            public const uint IMF_SPELLCHECKING = 0x0800;
            public const uint IMF_TKBPREDICTION = 0x1000;
            public const uint IMF_IMEUIINTEGRATION = 0x2000;
            public const uint ICM_NOTOPEN = 0x0000;
            public const uint ICM_LEVEL3 = 0x0001;
            public const uint ICM_LEVEL2 = 0x0002;
            public const uint ICM_LEVEL2_5 = 0x0003;
            public const uint ICM_LEVEL2_SUI = 0x0004;
            public const uint ICM_CTF = 0x0005;
            public const uint TO_ADVANCEDTYPOGRAPHY = 0x0001;
            public const uint TO_SIMPLELINEBREAK = 0x0002;
            public const uint TO_DISABLECUSTOMTEXTOUT = 0x0004;
            public const uint TO_ADVANCEDLAYOUT = 0x0008;
            public const uint EM_OUTLINE = (WM_USER + 220);
            public const uint EM_GETSCROLLPOS = (WM_USER + 221);
            public const uint EM_SETSCROLLPOS = (WM_USER + 222);
            public const uint EM_SETFONTSIZE = (WM_USER + 223);
            public const uint EM_GETZOOM = (WM_USER + 224);
            public const uint EM_SETZOOM = (WM_USER + 225);
            public const uint EM_GETVIEWKIND = (WM_USER + 226);
            public const uint EM_SETVIEWKIND = (WM_USER + 227);
            public const uint EM_GETPAGE = (WM_USER + 228);
            public const uint EM_SETPAGE = (WM_USER + 229);
            public const uint EM_GETHYPHENATEINFO = (WM_USER + 230);
            public const uint EM_SETHYPHENATEINFO = (WM_USER + 231);
            public const uint EM_GETPAGEROTATE = (WM_USER + 235);
            public const uint EM_SETPAGEROTATE = (WM_USER + 236);
            public const uint EM_GETCTFMODEBIAS = (WM_USER + 237);
            public const uint EM_SETCTFMODEBIAS = (WM_USER + 238);
            public const uint EM_GETCTFOPENSTATUS = (WM_USER + 240);
            public const uint EM_SETCTFOPENSTATUS = (WM_USER + 241);
            public const uint EM_GETIMECOMPTEXT = (WM_USER + 242);
            public const uint EM_ISIME = (WM_USER + 243);
            public const uint EM_GETIMEPROPERTY = (WM_USER + 244);
            public const uint EM_GETQUERYRTFOBJ = (WM_USER + 269);
            public const uint EM_SETQUERYRTFOBJ = (WM_USER + 270);
            public const uint EPR_0 = 0;// Text flows left to right and top to bottom
            public const uint EPR_270 = 1;// Text flows top to bottom and right to left
            public const uint EPR_180 = 2;// Text flows right to left and bottom to top
            public const uint EPR_90 = 3;// Text flows bottom to top and left to right
            public const uint EPR_SE = 5;// Text flows top to bottom and left to right (Mongolian text layout)
            public const uint CTFMODEBIAS_DEFAULT = 0x0000;
            public const uint CTFMODEBIAS_FILENAME = 0x0001;
            public const uint CTFMODEBIAS_NAME = 0x0002;
            public const uint CTFMODEBIAS_READING = 0x0003;
            public const uint CTFMODEBIAS_DATETIME = 0x0004;
            public const uint CTFMODEBIAS_CONVERSATION = 0x0005;
            public const uint CTFMODEBIAS_NUMERIC = 0x0006;
            public const uint CTFMODEBIAS_HIRAGANA = 0x0007;
            public const uint CTFMODEBIAS_KATAKANA = 0x0008;
            public const uint CTFMODEBIAS_HANGUL = 0x0009;
            public const uint CTFMODEBIAS_HALFWIDTHKATAKANA = 0x000A;
            public const uint CTFMODEBIAS_FULLWIDTHALPHANUMERIC = 0x000B;
            public const uint CTFMODEBIAS_HALFWIDTHALPHANUMERIC = 0x000C;
            public const uint IMF_SMODE_PLAURALCLAUSE = 0x0001;
            public const uint IMF_SMODE_NONE = 0x0002;
            public const uint ICT_RESULTREADSTR = 1;
            public const uint EMO_EXIT = 0;// Enter normal mode,  lparam ignored
            public const uint EMO_ENTER = 1;// Enter outline mode, lparam ignored
            public const uint EMO_PROMOTE = 2;// LOWORD(lparam) == 0 ==>
            public const uint EMO_EXPAND = 3;// HIWORD(lparam) = EMO_EXPANDSELECTION
            public const uint EMO_MOVESELECTION = 4;// LOWORD(lparam) != 0 -> move current
            public const uint EMO_GETVIEWMODE = 5;// Returns VM_NORMAL or VM_OUTLINE
            public const uint EMO_EXPANDSELECTION = 0;
            public const uint EMO_EXPANDDOCUMENT = 1;
            public const uint VM_NORMAL = 4;// Agrees with RTF \viewkindN
            public const uint VM_OUTLINE = 2;
            public const uint VM_PAGE = 9;// Screen page view (not print layout)
            public const uint EM_INSERTTABLE = (WM_USER + 232);
            public const uint EM_GETAUTOCORRECTPROC = (WM_USER + 233);
            public const uint EM_SETAUTOCORRECTPROC = (WM_USER + 234);
            public const uint EM_CALLAUTOCORRECTPROC = (WM_USER + 255);
            public const uint ATP_NOCHANGE = 0;
            public const uint ATP_CHANGE = 1;
            public const uint ATP_NODELIMITER = 2;
            public const uint ATP_REPLACEALLTEXT = 4;
            public const uint EM_GETTABLEPARMS = (WM_USER + 265);
            public const uint EM_SETEDITSTYLEEX = (WM_USER + 275);
            public const uint EM_GETEDITSTYLEEX = (WM_USER + 276);
            public const uint SES_EX_NOTABLE = 0x00000004;
            public const uint SES_EX_NOMATH = 0x00000040;
            public const uint SES_EX_HANDLEFRIENDLYURL = 0x00000100;
            public const uint SES_EX_NOTHEMING = 0x00080000;
            public const uint SES_EX_NOACETATESELECTION = 0x00100000;
            public const uint SES_EX_USESINGLELINE = 0x00200000;
            public const uint SES_EX_MULTITOUCH = 0x08000000;// Only works under Win8+
            public const uint SES_EX_HIDETEMPFORMAT = 0x10000000;
            public const uint SES_EX_USEMOUSEWPARAM = 0x20000000;// Use wParam when handling WM_MOUSEMOVE message and do not call GetAsyncKeyState
            public const uint EM_GETSTORYTYPE = (WM_USER + 290);
            public const uint EM_SETSTORYTYPE = (WM_USER + 291);
            public const uint EM_GETELLIPSISMODE = (WM_USER + 305);
            public const uint EM_SETELLIPSISMODE = (WM_USER + 306);
            public const uint ELLIPSIS_MASK = 0x00000003;// all meaningful bits
            public const uint ELLIPSIS_NONE = 0x00000000;// ellipsis disabled
            public const uint ELLIPSIS_END = 0x00000001;// ellipsis at the end (forced break)
            public const uint ELLIPSIS_WORD = 0x00000003;// ellipsis at the end (word break)
            public const uint EM_SETTABLEPARMS = (WM_USER + 307);
            public const uint EM_GETTOUCHOPTIONS = (WM_USER + 310);
            public const uint EM_SETTOUCHOPTIONS = (WM_USER + 311);
            public const uint EM_INSERTIMAGE = (WM_USER + 314);
            public const uint EM_SETUIANAME = (WM_USER + 320);
            public const uint EM_GETELLIPSISSTATE = (WM_USER + 322);
            public const uint RTO_SHOWHANDLES = 1;
            public const uint RTO_DISABLEHANDLES = 2;
            public const uint RTO_READINGMODE = 3;
            public const uint EN_MSGFILTER = 0x0700;
            public const uint EN_REQUESTRESIZE = 0x0701;
            public const uint EN_SELCHANGE = 0x0702;
            public const uint EN_DROPFILES = 0x0703;
            public const uint EN_PROTECTED = 0x0704;
            public const uint EN_CORRECTTEXT = 0x0705;// PenWin specific
            public const uint EN_STOPNOUNDO = 0x0706;
            public const uint EN_IMECHANGE = 0x0707;// East Asia specific
            public const uint EN_SAVECLIPBOARD = 0x0708;
            public const uint EN_OLEOPFAILED = 0x0709;
            public const uint EN_OBJECTPOSITIONS = 0x070a;
            public const uint EN_LINK = 0x070b;
            public const uint EN_DRAGDROPDONE = 0x070c;
            public const uint EN_PARAGRAPHEXPANDED = 0x070d;
            public const uint EN_PAGECHANGE = 0x070e;
            public const uint EN_LOWFIRTF = 0x070f;
            public const uint EN_ALIGNLTR = 0x0710;// BiDi specific notification
            public const uint EN_ALIGNRTL = 0x0711;// BiDi specific notification
            public const uint EN_CLIPFORMAT = 0x0712;
            public const uint EN_STARTCOMPOSITION = 0x0713;
            public const uint EN_ENDCOMPOSITION = 0x0714;
            public const uint ECN_ENDCOMPOSITION = 0x0001;
            public const uint ECN_NEWTEXT = 0x0002;
            public const uint ENM_NONE = 0x00000000;
            public const uint ENM_CHANGE = 0x00000001;
            public const uint ENM_UPDATE = 0x00000002;
            public const uint ENM_SCROLL = 0x00000004;
            public const uint ENM_SCROLLEVENTS = 0x00000008;
            public const uint ENM_DRAGDROPDONE = 0x00000010;
            public const uint ENM_PARAGRAPHEXPANDED = 0x00000020;
            public const uint ENM_PAGECHANGE = 0x00000040;
            public const uint ENM_CLIPFORMAT = 0x00000080;
            public const uint ENM_KEYEVENTS = 0x00010000;
            public const uint ENM_MOUSEEVENTS = 0x00020000;
            public const uint ENM_REQUESTRESIZE = 0x00040000;
            public const uint ENM_SELCHANGE = 0x00080000;
            public const uint ENM_DROPFILES = 0x00100000;
            public const uint ENM_PROTECTED = 0x00200000;
            public const uint ENM_CORRECTTEXT = 0x00400000;// PenWin specific
            public const uint ENM_IMECHANGE = 0x00800000;// Used by RE1.0 compatibility
            public const uint ENM_LANGCHANGE = 0x01000000;
            public const uint ENM_OBJECTPOSITIONS = 0x02000000;
            public const uint ENM_LINK = 0x04000000;
            public const uint ENM_LOWFIRTF = 0x08000000;
            public const uint ENM_STARTCOMPOSITION = 0x10000000;
            public const uint ENM_ENDCOMPOSITION = 0x20000000;
            public const uint ENM_GROUPTYPINGCHANGE = 0x40000000;
            public const uint ENM_HIDELINKTOOLTIP = 0x80000000;
            public const uint ES_SAVESEL = 0x00008000;
            public const uint ES_SUNKEN = 0x00004000;
            public const uint ES_DISABLENOSCROLL = 0x00002000;
            public const uint ES_SELECTIONBAR = 0x01000000;
            public const uint ES_NOOLEDRAGDROP = 0x00000008;
            public const uint ES_EX_NOCALLOLEINIT = 0x00000000;// Not supported in RE 2.0/3.0
            public const uint ES_VERTICAL = 0x00400000;// Not supported in RE 2.0/3.0
            public const uint ES_NOIME = 0x00080000;
            public const uint ES_SELFIME = 0x00040000;
            public const uint ECO_AUTOWORDSELECTION = 0x00000001;
            public const uint ECO_AUTOVSCROLL = 0x00000040;
            public const uint ECO_AUTOHSCROLL = 0x00000080;
            public const uint ECO_NOHIDESEL = 0x00000100;
            public const uint ECO_READONLY = 0x00000800;
            public const uint ECO_WANTRETURN = 0x00001000;
            public const uint ECO_SAVESEL = 0x00008000;
            public const uint ECO_SELECTIONBAR = 0x01000000;
            public const uint ECO_VERTICAL = 0x00400000;// FE specific
            public const uint ECOOP_SET = 0x0001;
            public const uint ECOOP_OR = 0x0002;
            public const uint ECOOP_AND = 0x0003;
            public const uint ECOOP_XOR = 0x0004;
            public const uint WB_CLASSIFY = 3;
            public const uint WB_MOVEWORDLEFT = 4;
            public const uint WB_MOVEWORDRIGHT = 5;
            public const uint WB_LEFTBREAK = 6;
            public const uint WB_RIGHTBREAK = 7;
            public const uint WB_MOVEWORDPREV = 4;
            public const uint WB_MOVEWORDNEXT = 5;
            public const uint WB_PREVBREAK = 6;
            public const uint WB_NEXTBREAK = 7;
            public const uint PC_FOLLOWING = 1;
            public const uint PC_LEADING = 2;
            public const uint PC_OVERFLOW = 3;
            public const uint PC_DELIMITER = 4;
            public const uint WBF_WORDWRAP = 0x010;
            public const uint WBF_WORDBREAK = 0x020;
            public const uint WBF_OVERFLOW = 0x040;
            public const uint WBF_LEVEL1 = 0x080;
            public const uint WBF_LEVEL2 = 0x100;
            public const uint WBF_CUSTOM = 0x200;
            public const uint IMF_FORCENONE = 0x0001;
            public const uint IMF_FORCEENABLE = 0x0002;
            public const uint IMF_FORCEDISABLE = 0x0004;
            public const uint IMF_CLOSESTATUSWINDOW = 0x0008;
            public const uint IMF_VERTICAL = 0x0020;
            public const uint IMF_FORCEACTIVE = 0x0040;
            public const uint IMF_FORCEINACTIVE = 0x0080;
            public const uint IMF_FORCEREMEMBER = 0x0100;
            public const uint IMF_MULTIPLEEDIT = 0x0400;
            public const uint WBF_CLASS = 0x0F;
            public const uint WBF_ISWHITE = 0x10;
            public const uint WBF_BREAKLINE = 0x20;
            public const uint WBF_BREAKAFTER = 0x40;
            public const uint CFM_BOLD = 0x00000001;
            public const uint CFM_ITALIC = 0x00000002;
            public const uint CFM_UNDERLINE = 0x00000004;
            public const uint CFM_STRIKEOUT = 0x00000008;
            public const uint CFM_PROTECTED = 0x00000010;
            public const uint CFM_LINK = 0x00000020;// Exchange hyperlink extension
            public const uint CFM_SIZE = 0x80000000;
            public const uint CFM_COLOR = 0x40000000;
            public const uint CFM_FACE = 0x20000000;
            public const uint CFM_OFFSET = 0x10000000;
            public const uint CFM_CHARSET = 0x08000000;
            public const uint CFE_BOLD = 0x00000001;
            public const uint CFE_ITALIC = 0x00000002;
            public const uint CFE_UNDERLINE = 0x00000004;
            public const uint CFE_STRIKEOUT = 0x00000008;
            public const uint CFE_PROTECTED = 0x00000010;
            public const uint CFE_LINK = 0x00000020;
            public const uint CFE_AUTOCOLOR = 0x40000000;// NOTE: this corresponds to
            public const uint CFM_SMALLCAPS = 0x00000040;// (*)
            public const uint CFM_ALLCAPS = 0x00000080;// Displayed by 3.0
            public const uint CFM_HIDDEN = 0x00000100;// Hidden by 3.0
            public const uint CFM_OUTLINE = 0x00000200;// (*)
            public const uint CFM_SHADOW = 0x00000400;// (*)
            public const uint CFM_EMBOSS = 0x00000800;// (*)
            public const uint CFM_IMPRINT = 0x00001000;// (*)
            public const uint CFM_DISABLED = 0x00002000;
            public const uint CFM_REVISED = 0x00004000;
            public const uint CFM_REVAUTHOR = 0x00008000;
            public const uint CFE_SUBSCRIPT = 0x00010000;// Superscript and subscript are
            public const uint CFE_SUPERSCRIPT = 0x00020000;//  mutually exclusive
            public const uint CFM_ANIMATION = 0x00040000;// (*)
            public const uint CFM_STYLE = 0x00080000;// (*)
            public const uint CFM_KERNING = 0x00100000;
            public const uint CFM_SPACING = 0x00200000;// Displayed by 3.0
            public const uint CFM_WEIGHT = 0x00400000;
            public const uint CFM_UNDERLINETYPE = 0x00800000;// Many displayed by 3.0
            public const uint CFM_COOKIE = 0x01000000;// RE 6.0
            public const uint CFM_LCID = 0x02000000;
            public const uint CFM_BACKCOLOR = 0x04000000;// Higher mask bits defined above
            public const uint CFM_SUBSCRIPT = (CFE_SUBSCRIPT | CFE_SUPERSCRIPT);
            public const uint CFM_SUPERSCRIPT = CFM_SUBSCRIPT;
            public const uint CFM_EFFECTS = (CFM_BOLD | CFM_ITALIC | CFM_UNDERLINE | CFM_COLOR | CFM_STRIKEOUT | CFE_PROTECTED | CFM_LINK);
            public const uint CFM_ALL = (CFM_EFFECTS | CFM_SIZE | CFM_FACE | CFM_OFFSET | CFM_CHARSET);
            public const uint CFM_EFFECTS2 = (CFM_EFFECTS | CFM_DISABLED | CFM_SMALLCAPS | CFM_ALLCAPS | CFM_HIDDEN | CFM_OUTLINE | CFM_SHADOW | CFM_EMBOSS | CFM_IMPRINT | CFM_REVISED | CFM_SUBSCRIPT | CFM_SUPERSCRIPT | CFM_BACKCOLOR);
            public const uint CFM_ALL2 = (CFM_ALL | CFM_EFFECTS2 | CFM_BACKCOLOR | CFM_LCID | CFM_UNDERLINETYPE | CFM_WEIGHT | CFM_REVAUTHOR | CFM_SPACING | CFM_KERNING | CFM_STYLE | CFM_ANIMATION | CFM_COOKIE);
            //public const uint CFM_ALL2 = (CFM_ALL | CFM_EFFECTS2 | CFM_BACKCOLOR | CFM_LCID \;
            public const uint CFE_SMALLCAPS = CFM_SMALLCAPS;
            public const uint CFE_ALLCAPS = CFM_ALLCAPS;
            public const uint CFE_HIDDEN = CFM_HIDDEN;
            public const uint CFE_OUTLINE = CFM_OUTLINE;
            public const uint CFE_SHADOW = CFM_SHADOW;
            public const uint CFE_EMBOSS = CFM_EMBOSS;
            public const uint CFE_IMPRINT = CFM_IMPRINT;
            public const uint CFE_DISABLED = CFM_DISABLED;
            public const uint CFE_REVISED = CFM_REVISED;
            public const uint CFE_AUTOBACKCOLOR = CFM_BACKCOLOR;
            public const uint CFM_FONTBOUND = 0x00100000;
            public const uint CFM_LINKPROTECTED = 0x00800000;// Word hyperlink field
            public const uint CFM_EXTENDED = 0x02000000;
            public const uint CFM_MATHNOBUILDUP = 0x08000000;
            public const uint CFM_MATH = 0x10000000;
            public const uint CFM_MATHORDINARY = 0x20000000;
            public const uint CFM_ALLEFFECTS = (CFM_EFFECTS2 | CFM_FONTBOUND | CFM_EXTENDED | CFM_MATHNOBUILDUP | CFM_MATH | CFM_MATHORDINARY);
            public const uint CFE_FONTBOUND = 0x00100000;// Font chosen by binder, not user
            public const uint CFE_LINKPROTECTED = 0x00800000;
            public const uint CFE_EXTENDED = 0x02000000;
            public const uint CFE_MATHNOBUILDUP = 0x08000000;
            public const uint CFE_MATH = 0x10000000;
            public const uint CFE_MATHORDINARY = 0x20000000;
            public const uint CFU_CF1UNDERLINE = 0xFF;// Map charformat's bit underline to CF2
            public const uint CFU_INVERT = 0xFE;// For IME composition fake a selection
            public const uint CFU_UNDERLINETHICKLONGDASH = 18;// (*) display as dash
            public const uint CFU_UNDERLINETHICKDOTTED = 17;// (*) display as dot
            public const uint CFU_UNDERLINETHICKDASHDOTDOT = 16;// (*) display as dash dot dot
            public const uint CFU_UNDERLINETHICKDASHDOT = 15;// (*) display as dash dot
            public const uint CFU_UNDERLINETHICKDASH = 14;// (*) display as dash
            public const uint CFU_UNDERLINELONGDASH = 13;// (*) display as dash
            public const uint CFU_UNDERLINEHEAVYWAVE = 12;// (*) display as wave
            public const uint CFU_UNDERLINEDOUBLEWAVE = 11;// (*) display as wave
            public const uint CFU_UNDERLINEHAIRLINE = 10;// (*) display as single
            public const uint CFU_UNDERLINETHICK = 9;
            public const uint CFU_UNDERLINEWAVE = 8;
            public const uint CFU_UNDERLINEDASHDOTDOT = 7;
            public const uint CFU_UNDERLINEDASHDOT = 6;
            public const uint CFU_UNDERLINEDASH = 5;
            public const uint CFU_UNDERLINEDOTTED = 4;
            public const uint CFU_UNDERLINEDOUBLE = 3;// (*) display as single
            public const uint CFU_UNDERLINEWORD = 2;// (*) display as single
            public const uint CFU_UNDERLINE = 1;
            public const uint CFU_UNDERLINENONE = 0;
            public const uint yHeightCharPtsMost = 1638;
            public const uint SCF_SELECTION = 0x0001;
            public const uint SCF_WORD = 0x0002;
            public const uint SCF_DEFAULT = 0x0000;// Set default charformat or paraformat
            public const uint SCF_ALL = 0x0004;// Not valid with SCF_SELECTION or SCF_WORD
            public const uint SCF_USEUIRULES = 0x0008;// Modifier for SCF_SELECTION; says that
            public const uint SCF_ASSOCIATEFONT = 0x0010;// Associate fontname with bCharSet (one
            public const uint SCF_NOKBUPDATE = 0x0020;// Do not update KB layout for this change
            public const uint SCF_ASSOCIATEFONT2 = 0x0040;// Associate plane-2 (surrogate) font
            public const uint SCF_SMARTFONT = 0x0080;// Apply font only if it can handle script (5.0)
            public const uint SCF_CHARREPFROMLCID = 0x0100;// Get character repertoire from lcid (5.0)
            public const uint SPF_DONTSETDEFAULT = 0x0002;// Suppress setting default on empty control
            public const uint SPF_SETDEFAULT = 0x0004;// Set the default paraformat
            public const uint SF_TEXT = 0x0001;
            public const uint SF_RTF = 0x0002;
            public const uint SF_RTFNOOBJS = 0x0003;// Write only
            public const uint SF_TEXTIZED = 0x0004;// Write only
            public const uint SF_UNICODE = 0x0010;// Unicode file (UCS2 little endian)
            public const uint SF_USECODEPAGE = 0x0020;// CodePage given by high word
            public const uint SF_NCRFORNONASCII = 0x40;// Output \uN for nonASCII
            public const uint SFF_WRITEXTRAPAR = 0x80;// Output \par at end
            public const uint SFF_SELECTION = 0x8000;
            public const uint SFF_PLAINRTF = 0x4000;
            public const uint SFF_PERSISTVIEWSCALE = 0x2000;
            public const uint SFF_KEEPDOCINFO = 0x1000;
            public const uint SFF_PWD = 0x0800;
            public const uint SF_RTFVAL = 0x0700;
            public const uint MAX_TAB_STOPS = 32;
            public const uint lDefaultTab = 720;
            public const uint MAX_TABLE_CELLS = 63;
            public const uint PFM_STARTINDENT = 0x00000001;
            public const uint PFM_RIGHTINDENT = 0x00000002;
            public const uint PFM_OFFSET = 0x00000004;
            public const uint PFM_ALIGNMENT = 0x00000008;
            public const uint PFM_TABSTOPS = 0x00000010;
            public const uint PFM_NUMBERING = 0x00000020;
            public const uint PFM_OFFSETINDENT = 0x80000000;
            public const uint PFM_SPACEBEFORE = 0x00000040;
            public const uint PFM_SPACEAFTER = 0x00000080;
            public const uint PFM_LINESPACING = 0x00000100;
            public const uint PFM_STYLE = 0x00000400;
            public const uint PFM_BORDER = 0x00000800;// (*)
            public const uint PFM_SHADING = 0x00001000;// (*)
            public const uint PFM_NUMBERINGSTYLE = 0x00002000;// RE 3.0
            public const uint PFM_NUMBERINGTAB = 0x00004000;// RE 3.0
            public const uint PFM_NUMBERINGSTART = 0x00008000;// RE 3.0
            public const uint PFM_RTLPARA = 0x00010000;
            public const uint PFM_KEEP = 0x00020000;// (*)
            public const uint PFM_KEEPNEXT = 0x00040000;// (*)
            public const uint PFM_PAGEBREAKBEFORE = 0x00080000;// (*)
            public const uint PFM_NOLINENUMBER = 0x00100000;// (*)
            public const uint PFM_NOWIDOWCONTROL = 0x00200000;// (*)
            public const uint PFM_DONOTHYPHEN = 0x00400000;// (*)
            public const uint PFM_SIDEBYSIDE = 0x00800000;// (*)
            public const uint PFM_COLLAPSED = 0x01000000;// RE 3.0
            public const uint PFM_OUTLINELEVEL = 0x02000000;// RE 3.0
            public const uint PFM_BOX = 0x04000000;// RE 3.0
            public const uint PFM_RESERVED2 = 0x08000000;// RE 4.0
            public const uint PFM_TABLEROWDELIMITER = 0x10000000;// RE 4.0
            public const uint PFM_TEXTWRAPPINGBREAK = 0x20000000;// RE 3.0
            public const uint PFM_TABLE = 0x40000000;// RE 3.0
            public const uint PFM_ALL = (PFM_STARTINDENT | PFM_RIGHTINDENT | PFM_OFFSET | PFM_ALIGNMENT | PFM_TABSTOPS | PFM_NUMBERING | PFM_OFFSETINDENT | PFM_RTLPARA);
            public const uint PFM_EFFECTS = (PFM_RTLPARA | PFM_KEEP | PFM_KEEPNEXT | PFM_TABLE | PFM_PAGEBREAKBEFORE | PFM_NOLINENUMBER | PFM_NOWIDOWCONTROL | PFM_DONOTHYPHEN | PFM_SIDEBYSIDE | PFM_TABLE | PFM_TABLEROWDELIMITER);
            public const uint PFM_ALL2 = (PFM_ALL | PFM_EFFECTS | PFM_SPACEBEFORE | PFM_SPACEAFTER | PFM_LINESPACING | PFM_STYLE | PFM_SHADING | PFM_BORDER | PFM_NUMBERINGTAB | PFM_NUMBERINGSTART | PFM_NUMBERINGSTYLE);
            public const uint PFE_RTLPARA = (PFM_RTLPARA >> 16);
            public const uint PFE_KEEP = (PFM_KEEP >> 16);// (*)
            public const uint PFE_KEEPNEXT = (PFM_KEEPNEXT >> 16);// (*)
            public const uint PFE_PAGEBREAKBEFORE = (PFM_PAGEBREAKBEFORE >> 16);// (*)
            public const uint PFE_NOLINENUMBER = (PFM_NOLINENUMBER >> 16);// (*)
            public const uint PFE_NOWIDOWCONTROL = (PFM_NOWIDOWCONTROL >> 16);// (*)
            public const uint PFE_DONOTHYPHEN = (PFM_DONOTHYPHEN >> 16);// (*)
            public const uint PFE_SIDEBYSIDE = (PFM_SIDEBYSIDE >> 16);// (*)
            public const uint PFE_TEXTWRAPPINGBREAK = (PFM_TEXTWRAPPINGBREAK >> 16);// (*)
            public const uint PFE_COLLAPSED = (PFM_COLLAPSED >> 16);// (+)
            public const uint PFE_BOX = (PFM_BOX >> 16);// (+)
            public const uint PFE_TABLE = (PFM_TABLE >> 16);// Inside table row. RE 3.0
            public const uint PFE_TABLEROWDELIMITER = (PFM_TABLEROWDELIMITER >> 16);// Table row start. RE 4.0
            public const uint PFN_BULLET = 1;// tomListBullet
            public const uint PFN_ARABIC = 2;// tomListNumberAsArabic:   0, 1, 2,    ...
            public const uint PFN_LCLETTER = 3;// tomListNumberAsLCLetter: a, b, c,    ...
            public const uint PFN_UCLETTER = 4;// tomListNumberAsUCLetter: A, B, C,    ...
            public const uint PFN_LCROMAN = 5;// tomListNumberAsLCRoman:  i, ii, iii, ...
            public const uint PFN_UCROMAN = 6;// tomListNumberAsUCRoman:  I, II, III, ...
            public const uint PFNS_PAREN = 0x000;// default, e.g.,                 1)
            public const uint PFNS_PARENS = 0x100;// tomListParentheses/256, e.g., (1)
            public const uint PFNS_PERIOD = 0x200;// tomListPeriod/256, e.g.,       1.
            public const uint PFNS_PLAIN = 0x300;// tomListPlain/256, e.g.,        1
            public const uint PFNS_NONUMBER = 0x400;// Used for continuation w/o number
            public const uint PFNS_NEWNUMBER = 0x8000;// Start new number with wNumberingStart
            public const uint PFA_LEFT = 1;
            public const uint PFA_RIGHT = 2;
            public const uint PFA_CENTER = 3;
            public const uint PFA_JUSTIFY = 4;// New paragraph-alignment option 2.0 (*)
            public const uint PFA_FULL_INTERWORD = 4;// These are supported in 3.0 with advanced

            public const uint WM_NOTIFY = 0x004E;
            public const uint SEL_EMPTY = 0x0000;
            public const uint SEL_TEXT = 0x0001;
            public const uint SEL_OBJECT = 0x0002;
            public const uint SEL_MULTICHAR = 0x0004;
            public const uint SEL_MULTIOBJECT = 0x0008;
            public const uint GCM_RIGHTMOUSEDROP = 0x8000;
            public const uint GCMF_GRIPPER = 0x00000001;
            public const uint GCMF_SPELLING = 0x00000002;// pSpellingSuggestions is valid
            public const uint GCMF_TOUCHMENU = 0x00004000;
            public const uint GCMF_MOUSEMENU = 0x00002000;
            public const uint OLEOP_DOVERB = 1;
            public const string CF_RTF = "Rich Text Format";
            public const string CF_RTFNOOBJS = "Rich Text Format Without Objects";
            public const string CF_RETEXTOBJ = "RichEdit Text and Objects";

            public const uint ST_DEFAULT = 0;
            public const uint ST_KEEPUNDO = 1;
            public const uint ST_SELECTION = 2;
            public const uint ST_NEWCHARS = 4;
            public const uint ST_UNICODE = 8;
            public const uint GT_DEFAULT = 0;
            public const uint GT_USECRLF = 1;
            public const uint GT_SELECTION = 2;
            public const uint GT_RAWTEXT = 4;
            public const uint GT_NOHIDDENTEXT = 8;
            public const uint GTL_DEFAULT = 0;// Do default (return # of chars)
            public const uint GTL_USECRLF = 1;// Compute answer using CRLFs for paragraphs
            public const uint GTL_PRECISE = 2;// Compute a precise answer
            public const uint GTL_CLOSE = 4;// Fast computation of a "close" answer
            public const uint GTL_NUMCHARS = 8;// Return number of characters
            public const uint GTL_NUMBYTES = 16;// Return number of _bytes_
            public const uint BOM_DEFPARADIR = 0x0001;// Default paragraph direction (implies alignment) (obsolete)
            public const uint BOM_PLAINTEXT = 0x0002;// Use plain text layout (obsolete)
            public const uint BOM_NEUTRALOVERRIDE = 0x0004;// Override neutral layout (obsolete)
            public const uint BOM_CONTEXTREADING = 0x0008;// Context reading order
            public const uint BOM_CONTEXTALIGNMENT = 0x0010;// Context alignment
            public const uint BOM_LEGACYBIDICLASS = 0x0040;// Legacy Bidi classification (obsolete)
            public const uint BOM_UNICODEBIDI = 0x0080;// Use Unicode BiDi algorithm
            public const uint BOE_RTLDIR = 0x0001;// Default paragraph direction (implies alignment) (obsolete)
            public const uint BOE_PLAINTEXT = 0x0002;// Use plain text layout (obsolete)
            public const uint BOE_NEUTRALOVERRIDE = 0x0004;// Override neutral layout (obsolete)
            public const uint BOE_CONTEXTREADING = 0x0008;// Context reading order
            public const uint BOE_CONTEXTALIGNMENT = 0x0010;// Context alignment
            public const uint BOE_FORCERECALC = 0x0020;// Force recalc and redraw
            public const uint BOE_LEGACYBIDICLASS = 0x0040;// Legacy Bidi classification (obsolete)
            public const uint BOE_UNICODEBIDI = 0x0080;// Use Unicode BiDi algorithm

            public const uint FR_MATCHDIAC = 0x20000000;
            public const uint FR_MATCHKASHIDA = 0x40000000;
            public const uint FR_MATCHALEFHAMZA = 0x80000000;
            public const uint WCH_EMBEDDING = 0xFFFC;
            public const uint PFA_FULL_NEWSPAPER = 5;// Not implemented
            public const uint PFA_FULL_INTERLETTER = 6;// Not implemented
            public const uint PFA_FULL_SCALED = 7;// Not implemented
            public const uint PFA_FULL_GLYPHS = 8;// Not implemented
            public const uint AURL_ENABLEEA = 1;// Deprecated: use AURL_ENABLEEAURLS
            public const uint GCM_TOUCHMENU = 0x4000;// Deprecated: Use GCMF_TOUCHMENU
            public const uint GCM_MOUSEMENU = 0x2000;// Deprecated: Use GCMF_MOUSEMENU 

        }


        [StructLayout(LayoutKind.Sequential)]
        public struct TABLEROWPARMS
        {

            /// BYTE->unsigned char
            public byte cbRow;

            /// BYTE->unsigned char
            public byte cbCell;

            /// BYTE->unsigned char
            public byte cCell;

            /// BYTE->unsigned char
            public byte cRow;

            /// LONG->int
            public int dxCellMargin;

            /// LONG->int
            public int dxIndent;

            /// LONG->int
            public int dyHeight;

            /// nAlignment : 3
            ///fRTL : 1
            ///fKeep : 1
            ///fKeepFollow : 1
            ///fWrap : 1
            ///fIdentCells : 1
            public uint bitvector1;

            /// LONG->int
            public int cpStartRow;

            /// BYTE->unsigned char
            public byte bTableLevel;

            /// BYTE->unsigned char
            public byte iCell;

            public uint nAlignment
            {
                get
                {
                    return ((uint)((this.bitvector1 & 7u)));
                }
                set
                {
                    this.bitvector1 = ((uint)((value | this.bitvector1)));
                }
            }

            public uint fRTL
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 8u)
                                / 8D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 8D) | this.bitvector1)));
                }
            }

            public uint fKeep
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 16u)
                                / 16D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 16D) | this.bitvector1)));
                }
            }

            public uint fKeepFollow
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 32u)
                                / 32D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 32D)
                                | this.bitvector1)));
                }
            }

            public uint fWrap
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 64u)
                                / 64D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 64D)
                                | this.bitvector1)));
                }
            }

            public uint fIdentCells
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 128u)
                                / 128D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 128D)
                                | this.bitvector1)));
                }
            }
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct TABLECELLPARMS
        {

            /// LONG->int
            public int dxWidth;

            /// nVertAlign : 2
            ///fMergeTop : 1
            ///fMergePrev : 1
            ///fVertical : 1
            ///fMergeStart : 1
            ///fMergeCont : 1
            public uint bitvector1;

            /// WORD->unsigned short
            public ushort wShading;

            /// SHORT->short
            public short dxBrdrLeft;

            /// SHORT->short
            public short dyBrdrTop;

            /// SHORT->short
            public short dxBrdrRight;

            /// SHORT->short
            public short dyBrdrBottom;

            /// COLORREF->DWORD->unsigned int
            public uint crBrdrLeft;

            /// COLORREF->DWORD->unsigned int
            public uint crBrdrTop;

            /// COLORREF->DWORD->unsigned int
            public uint crBrdrRight;

            /// COLORREF->DWORD->unsigned int
            public uint crBrdrBottom;

            /// COLORREF->DWORD->unsigned int
            public uint crBackPat;

            /// COLORREF->DWORD->unsigned int
            public uint crForePat;

            public uint nVertAlign
            {
                get
                {
                    return ((uint)((this.bitvector1 & 3u)));
                }
                set
                {
                    this.bitvector1 = ((uint)((value | this.bitvector1)));
                }
            }

            public uint fMergeTop
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 4u)
                                / 4D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 4D)
                                | this.bitvector1)));
                }
            }

            public uint fMergePrev
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 8u)
                                / 8D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 8D)
                                | this.bitvector1)));
                }
            }

            public uint fVertical
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 16u)
                                / 16D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 16D)
                                | this.bitvector1)));
                }
            }

            public uint fMergeStart
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 32u)
                                / 32D)));
                }
                set
                {
                    this.bitvector1 = (uint)(value * 32D)
                                | this.bitvector1;
                }
            }

            public uint fMergeCont
            {
                get
                {
                    return ((uint)(((this.bitvector1 & 64u)
                                / 64D)));
                }
                set
                {
                    this.bitvector1 = ((uint)(((uint)(value * 64D)
                                | this.bitvector1)));
                }
            }
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct tagRICHEDIT_IMAGE_PARAMETERS
        {

            /// LONG->int
            public int xWidth;

            /// LONG->int
            public int yHeight;

            /// LONG->int
            public int Ascent;

            /// LONG->int
            public int Type;

            /// LPCWSTR->WCHAR*
            [MarshalAs(UnmanagedType.LPWStr)]
            public string pwszAlternateText;

            /// IStream*
            public IntPtr pIStream;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENDCOMPOSITIONNOTIFY
        {

            /// NMHDR->tagNMHDR
            public NmHdr nmhdr;

            /// DWORD->unsigned int
            public uint dwCode;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CHARFORMATW
        {

            /// UINT->unsigned int
            public uint cbSize;

            /// DWORD->unsigned int
            public uint dwMask;

            /// DWORD->unsigned int
            public uint dwEffects;

            /// LONG->int
            public int yHeight;

            /// LONG->int
            public int yOffset;

            /// COLORREF->DWORD->unsigned int
            public uint crTextColor;

            /// BYTE->unsigned char
            public byte bCharSet;

            /// BYTE->unsigned char
            public byte bPitchAndFamily;

            /// WCHAR[32]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szFaceName;
        }
        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous_5813949a_9165_4265_939c_964d63e283ae
        {

            /// DWORD->unsigned int
            [FieldOffset(0)]
            public uint dwReserved;

            /// DWORD->unsigned int
            [FieldOffset(0)]
            public uint dwCookie;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        public struct CHARFORMAT2W
        {

            /// UINT->unsigned int
            public uint cbSize;

            /// DWORD->unsigned int
            public uint dwMask;

            /// DWORD->unsigned int
            public uint dwEffects;

            /// LONG->int
            public int yHeight;

            /// LONG->int
            public int yOffset;

            /// COLORREF->DWORD->unsigned int
            public uint crTextColor;

            /// BYTE->unsigned char
            public byte bCharSet;

            /// BYTE->unsigned char
            public byte bPitchAndFamily;

            /// WCHAR[32]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szFaceName;

            /// WORD->unsigned short
            public ushort wWeight;

            /// SHORT->short
            public short sSpacing;

            /// COLORREF->DWORD->unsigned int
            public uint crBackColor;

            /// LCID->DWORD->unsigned int
            public uint lcid;

            /// Anonymous_5813949a_9165_4265_939c_964d63e283ae
            public Anonymous_5813949a_9165_4265_939c_964d63e283ae Union1;

            /// SHORT->short
            public short sStyle;

            /// WORD->unsigned short
            public ushort wKerning;

            /// BYTE->unsigned char
            public byte bUnderlineType;

            /// BYTE->unsigned char
            public byte bAnimation;

            /// BYTE->unsigned char
            public byte bRevAuthor;

            /// BYTE->unsigned char
            public byte bUnderlineColor;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CHARRANGE
        {

            /// LONG->int
            public int cpMin;

            /// LONG->int
            public int cpMax;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct TEXTRANGEW
        {

            /// CHARRANGE->_charrange
            public CHARRANGE chrg;

            /// LPWSTR->WCHAR*
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpstrText;
        }

        private unsafe EDITSTREAM64 ConvertToEDITSTREAM64(EDITSTREAM es)
        {
            EDITSTREAM64 es64 = new EDITSTREAM64();

            fixed (byte* es64p = &es64.contents[0])
            {
                byte* bp;
                long l;

                /*
                l = (long) es.dwCookie;
                bp = (byte *) &l;
                for (int i=0; i < sizeof(long); i++) {
                    es64.contents[i] = bp[i];
                }*/
                *((long*)es64p) = (long)es.dwCookie;
                /*
                int il = es.dwError;
                bp = (byte *) &il;
                for (int i=0; i < sizeof(int); i++) {
                    es64.contents[i+8] = bp[i];
                }*/
                *((int*)(es64p + 8)) = es.dwError;

                l = (long)Marshal.GetFunctionPointerForDelegate(es.pfnCallback);
                bp = (byte*)&l;
                for (int i = 0; i < sizeof(long); i++)
                {
                    es64.contents[i + 12] = bp[i];
                }
                //*((long *)(es64p + 12)) = (long) Marshal.GetFunctionPointerForDelegate(es.pfnCallback);
            }

            return es64;
        }
        /// Return Type: DWORD->unsigned int
        ///dwCookie: DWORD_PTR->ULONG_PTR->unsigned int
        ///pbBuff: LPBYTE->BYTE*
        ///cb: LONG->int
        public delegate int EDITSTREAMCALLBACK(IntPtr dwCookie, IntPtr pbBuff, int cb, out int pcb);
        [StructLayout(LayoutKind.Sequential)]
        public class EDITSTREAM64
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] contents = new byte[20];
        }

        [StructLayout(LayoutKind.Sequential)]
        public class EDITSTREAM
        {

            /// DWORD_PTR->ULONG_PTR->unsigned int
            public IntPtr dwCookie = IntPtr.Zero;

            /// DWORD->unsigned int
            public int dwError;

            /// EDITSTREAMCALLBACK
            public EDITSTREAMCALLBACK pfnCallback = null;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FINDTEXTW
        {
            public CHARRANGE chrg;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpstrText;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FINDTEXTEXW
        {
            public CHARRANGE chrg;
            [MarshalAs(UnmanagedType.LPWStr)]
            public string lpstrText;
            public CHARRANGE chrgText;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct FORMATRANGE
        {
            public IntPtr hdc;
            public IntPtr hdcTarget;
            public Rect rc;
            public Rect rcPage;
            public CHARRANGE chrg;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous_02f0309b_fd07_464a_b85b_64c41a81b465
        {

            /// WORD->unsigned short
            [FieldOffset(0)]
            public ushort wReserved;

            /// WORD->unsigned short
            [FieldOffset(0)]
            public ushort wEffects;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT
        {

            /// UINT->unsigned int
            public uint cbSize;

            /// DWORD->unsigned int
            public uint dwMask;

            /// WORD->unsigned short
            public ushort wNumbering;

            /// Anonymous_02f0309b_fd07_464a_b85b_64c41a81b465
            public Anonymous_02f0309b_fd07_464a_b85b_64c41a81b465 Union1;

            /// LONG->int
            public int dxStartIndent;

            /// LONG->int
            public int dxRightIndent;

            /// LONG->int
            public int dxOffset;

            /// WORD->unsigned short
            public ushort wAlignment;

            /// SHORT->short
            public short cTabCount;

            /// LONG[32]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] rgxTabs;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Anonymous_e786f493_f3c4_42ac_a09f_6228df1a38d9
        {

            /// WORD->unsigned short
            [FieldOffset(0)]
            public ushort wReserved;

            /// WORD->unsigned short
            [FieldOffset(0)]
            public ushort wEffects;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PARAFORMAT2
        {

            /// UINT->unsigned int
            public uint cbSize;

            /// DWORD->unsigned int
            public uint dwMask;

            /// WORD->unsigned short
            public ushort wNumbering;

            /// Anonymous_e786f493_f3c4_42ac_a09f_6228df1a38d9
            public Anonymous_e786f493_f3c4_42ac_a09f_6228df1a38d9 Union1;

            /// LONG->int
            public int dxStartIndent;

            /// LONG->int
            public int dxRightIndent;

            /// LONG->int
            public int dxOffset;

            /// WORD->unsigned short
            public ushort wAlignment;

            /// SHORT->short
            public short cTabCount;

            /// LONG[32]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] rgxTabs;

            /// LONG->int
            public int dySpaceBefore;

            /// LONG->int
            public int dySpaceAfter;

            /// LONG->int
            public int dyLineSpacing;

            /// SHORT->short
            public short sStyle;

            /// BYTE->unsigned char
            public byte bLineSpacingRule;

            /// BYTE->unsigned char
            public byte bOutlineLevel;

            /// WORD->unsigned short
            public ushort wShadingWeight;

            /// WORD->unsigned short
            public ushort wShadingStyle;

            /// WORD->unsigned short
            public ushort wNumberingStart;

            /// WORD->unsigned short
            public ushort wNumberingStyle;

            /// WORD->unsigned short
            public ushort wNumberingTab;

            /// WORD->unsigned short
            public ushort wBorderSpace;

            /// WORD->unsigned short
            public ushort wBorderWidth;

            /// WORD->unsigned short
            public ushort wBorders;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSGFILTER
        {
            public NmHdr nmhdr;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct REQRESIZE
        {
            public NmHdr nmhdr;
            public Rect rc;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SELCHANGE
        {
            public NmHdr nmhdr;
            public CHARRANGE chrg;
            public ushort seltyp;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GROUPTYPINGCHANGE
        {
            public NmHdr nmhdr;
            public bool fGroupTyping;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CLIPBOARDFORMAT
        {

            /// NMHDR->tagNMHDR
            public NmHdr nmhdr;

            /// CLIPFORMAT->WORD->unsigned short
            public ushort cf;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GETCONTEXTMENUEX
        {
            public CHARRANGE chrg;
            public uint dwFlags;
            public Point pt;
            public IntPtr pvReserved;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENDROPFILES
        {
            public NmHdr nmhdr;
            public IntPtr hDrop;
            public int cp;
            public bool fProtected;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENPROTECTED
        {
            public NmHdr nmhdr;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public CHARRANGE chrg;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ENSAVECLIPBOARD
        {
            public NmHdr nmhdr;
            public int cObjectCount;
            public int cch;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ENOLEOPFAILED
        {
            public NmHdr nmhdr;
            public int iob;
            public int lOper;
            public int hr;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct OBJECTPOSITIONS
        {
            public NmHdr nmhdr;
            public int cObjectCount;
            public IntPtr pcpPositions;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENLINK
        {
            public NmHdr nmhdr;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public CHARRANGE chrg;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENLOWFIRTF
        {
            public NmHdr nmhdr;
            [MarshalAs(UnmanagedType.LPStr)]
            public string szControl;

        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ENCORRECTTEXT
        {
            public NmHdr nmhdr;
            public CHARRANGE chrg;
            public ushort seltyp;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct PUNCTUATION
        {
            public uint iSize;
            [MarshalAs(UnmanagedType.LPStr)]
            public string szPunctuation;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct COMPCOLOR
        {
            public uint crText;
            public uint crBackground;
            public uint dwEffects;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct REPASTESPECIAL
        {
            public uint dwAspect;
            public UIntPtr dwParam;
        }



        /// Return Type: int
        ///langid: LANGID->WORD->unsigned short
        ///pszBefore: WCHAR*
        ///pszAfter: WCHAR*
        ///cchAfter: LONG->int
        ///pcchReplaced: LONG*
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int AutoCorrectProc(ushort langid, [In()][MarshalAs(UnmanagedType.LPWStr)] string pszBefore, IntPtr pszAfter, int cchAfter, ref int pcchReplaced);


        private string _Text;
        //private const uint EM_SETTEXTEX = (WindowsMessages.WM_USER + 97);
        ////#define ES_SAVESEL				0x00008000
        //private const uint ES_SAVESEL = 0x00008000;
        [StructLayout(LayoutKind.Sequential)]
        private struct SETTEXTEX
        {

            /// DWORD->unsigned int
            public uint flags;

            /// UINT->unsigned int
            public uint codepage;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct GETTEXTEX
        {

            /// DWORD->unsigned int
            public uint cb;

            /// DWORD->unsigned int
            public uint flags;

            /// UINT->unsigned int
            public uint codepage;

            /// LPCSTR->CHAR*
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpDefaultChar;

            /// LPBOOL->BOOL*
            public IntPtr lpUsedDefChar;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct GETTEXTLENGTHEX
        {
            public uint flags;
            public uint codepage;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct BIDIOPTIONS
        {
            public uint cbSize;
            public ushort wMask;
            public ushort wEffects;
        }

        public enum KHYPH
        {

            khyphNil,

            khyphNormal,

            khyphAddBefore,

            khyphChangeBefore,

            khyphDeleteBefore,

            khyphChangeAfter,

            khyphDelAndChange,
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HYPHRESULT
        {

            /// KHYPH->tagKHYPH
            public KHYPH khyph;

            /// int
            public int ichHyph;

            /// WCHAR->wchar_t->unsigned short
            public ushort chHyph;
        }


        /// Return Type: void
        ///param0: WCHAR*
        ///param1: LANGID->WORD->unsigned short
        ///param2: int
        ///param3: HYPHRESULT*
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void tagHyphenateInfo_pfnHyphenate(IntPtr param0, ushort param1, int param2, ref HYPHRESULT param3);

        [StructLayout(LayoutKind.Sequential)]
        public struct tagHyphenateInfo
        {

            /// SHORT->short
            public short cbSize;

            /// SHORT->short
            public short dxHyphenateZone;

            /// tagHyphenateInfo_pfnHyphenate
            public tagHyphenateInfo_pfnHyphenate AnonymousMember1;
        }


        [Flags]
        public enum TextMode : int
        {

            /// TM_PLAINTEXT -> 1
            TM_PLAINTEXT = 1,

            /// TM_RICHTEXT -> 2
            TM_RICHTEXT = 2,

            /// TM_SINGLELEVELUNDO -> 4
            TM_SINGLELEVELUNDO = 4,

            /// TM_MULTILEVELUNDO -> 8
            TM_MULTILEVELUNDO = 8,

            /// TM_SINGLECODEPAGE -> 16
            TM_SINGLECODEPAGE = 16,

            /// TM_MULTICODEPAGE -> 32
            TM_MULTICODEPAGE = 32,
        }

        public class SetTextFalgs
        {
            public const uint ST_DEFAULT = 0x00;
            public const uint ST_KEEPUNDO = 0x01;
            public const uint ST_SELECTION = 0x02;
            public const uint ST_NEWCHARS = 0x04;
            public const uint ST_UNICODE = 0x08;
            public const uint ST_PLACEHOLDERTEXT = 0x10;
            public const uint ST_PLAINTEXTONLY = 0x20;
        }

        internal const int INPUT = 0x0001;
        internal const int OUTPUT = 0x0002;
        internal const int DIRECTIONMASK = INPUT | OUTPUT;
        internal const int ANSI = 0x0004;
        internal const int UNICODE = 0x0008;
        internal const int FORMATMASK = ANSI | UNICODE;
        internal const int TEXTLF = 0x0010;
        internal const int TEXTCRLF = 0x0020;
        internal const int RTF = 0x0040;
        internal const int KINDMASK = TEXTLF | TEXTCRLF | RTF;

        protected override void Initialize()
        {
            //Kernel32.LoadLibrary("Msftedit.dll");
            Kernel32.LoadLibrary("C:\\Program Files\\Microsoft Office\\root\\vfs\\ProgramFilesCommonX64\\Microsoft Shared\\Office16\\riched20.dll");
            base.Initialize();
            this.TypeIdentifier = "RICHEDIT60W";//"RICHEDIT50W";
            //this.TypeIdentifier = "RICHEDIT50W";
            this.Style = this.Style | EditBoxStyles.ES_MULTILINE | RichtTextBoxConst.ES_SAVESEL | EditBoxStyles.ES_WANTRETURN | WindowStylesConst.WS_HSCROLL | WindowStylesConst.WS_VSCROLL;

        }

        //public void Load(string filePath)
        //{
        //    Stream file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        //    try
        //    {
        //        this.editStream = file;
        //        var es = default(EDITSTREAM);
        //        es.dwCookie = (UIntPtr)SF_RTF;
        //        var callback = new EDITSTREAMCALLBACK(EditStreamCallback);

        //        es.pfnCallback = Marshal.GetFunctionPointerForDelegate(callback);

        //        SendMessageW(this.Handle, RichEditMessages.EM_STREAMIN, (int)SF_RTF, ref es);
        //        GC.KeepAlive(callback);
        //    }
        //    finally
        //    {
        //        file.Close();
        //    }
        //}

        //private void StreamIn(Stream data)
        //{
        //    try
        //    {
        //        this.editStream = data;

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        throw;
        //    }
        //}

        //private Stream editStream;
        //private int EditStreamCallback(IntPtr dwcookie, IntPtr pbbuff, int cb, out int pcb)
        //{

        //}

        //private IntPtr EditStreamCallback(IntPtr dwCookie, IntPtr pbBuff, IntPtr cb, IntPtr pcb)
        //{
        //    int result = -1;

        //    if (ReadFile(dwCookie, pbBuff, (uint)cb, pcb, IntPtr.Zero))
        //    {
        //        result = 0;
        //    }



        //    return new IntPtr(result);
        //}
        public int Length
        {
            get
            {
                GETTEXTLENGTHEX gtl = new GETTEXTLENGTHEX
                {
                    flags = RichtTextBoxConst.GTL_DEFAULT,
                    codepage = 1200
                };

                using (var p = new ApiStructHandleRef<GETTEXTLENGTHEX>(gtl))
                {
                    IntPtr result = User32.SendMessage(this.Handle, RichtTextBoxConst.EM_GETTEXTLENGTHEX, p.Handle, IntPtr.Zero);
                    int v = result.ToInt32();
                    if (v == HRESULT.E_INVALIDARG)
                    {
                        return -1;
                    }
                    else
                    {
                        return v;
                    }
                }

            }

        }

        public int GetByteCount()
        {
            GETTEXTLENGTHEX gtl = new GETTEXTLENGTHEX
            {
                flags = RichtTextBoxConst.GTL_NUMBYTES,
                codepage = 1200
            };
            using (var p = new ApiStructHandleRef<GETTEXTLENGTHEX>(gtl))
            {
                IntPtr result = User32.SendMessage(this.Handle, RichtTextBoxConst.EM_GETTEXTLENGTHEX, p.Handle, IntPtr.Zero);
                int v = result.ToInt32();
                if (v == HRESULT.E_INVALIDARG)
                {
                    return -1;
                }
                else
                {
                    return v;
                }
            }
        }
        //private static unsafe IntPtr SendMessage<TLParam>(IntPtr hWnd, uint msg, IntPtr wParam, ref TLParam lParam) where TLParam : unmanaged
        //{
        //    fixed (void* l = &lParam)
        //    {

        //        return User32.SendMessage(hWnd, msg, wParam, l);
        //    }
        //}
        public int GetTextMode()
        {
            IntPtr result = User32.SendMessage(this.Handle, RichtTextBoxConst.EM_GETTEXTMODE);
            int v = result.ToInt32();
            return v;
        }
        public void SetTextMode(TextMode mode)
        {
            IntPtr result = User32.SendMessage(this.Handle, (int)RichtTextBoxConst.EM_SETTEXTMODE, (int)mode, 0);
            if (result != IntPtr.Zero)
            {
                throw new Exception("Could not set the mode!");
            }

        }
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam, EDITSTREAM lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam, EDITSTREAM64 lParam);
        private unsafe int GetErrorValue64(EDITSTREAM64 es64)
        {
            int errorVal;

            fixed (byte* es64p = &es64.contents[0])
            {
                errorVal = *((int*)(es64p + 8));
            }

            return errorVal;
        }
        public string GetRTF()
        {
            _editStream = new MemoryStream();
            string retVal = string.Empty;
            //EDITSTREAMCALLBACK cm = OutEditStreamFunction;
            int cookieVal = OUTPUT | UNICODE;
            cookieVal |= RTF;
            EDITSTREAM es = new EDITSTREAM();
            es.dwError = 0;
            es.dwCookie = (IntPtr)cookieVal;
            es.pfnCallback = new EDITSTREAMCALLBACK(OutEditStreamFunction);
            EDITSTREAM64 es64 = ConvertToEDITSTREAM64(es);
            SendMessage(this.Handle, RichtTextBoxConst.EM_STREAMOUT, RichtTextBoxConst.SF_RTF, es64);
            //GC.KeepAlive(cm);
            es.dwError = GetErrorValue64(es64);

            if (es.dwError != 0)
            {
                throw new InvalidOperationException("Could not get RTF");
            }


            _editStream.Position = 0;
            using (var streamReader = new StreamReader(_editStream))
            {
                retVal = streamReader.ReadToEnd();

            }
            _editStream.Dispose();
            return retVal;
        }

        public void SetRTF(string value)
        {
            _editStream = new MemoryStream();
            byte[] bytes = Encoding.ASCII.GetBytes(value);
           
            _editStream.Write(bytes, 0, bytes.Length);

            _editStream.Position = 0;

            int cookieVal = INPUT | UNICODE | RTF;
            EDITSTREAM es = new EDITSTREAM();
            
            es.dwError = 0;
            es.dwCookie = (IntPtr)cookieVal;
            es.pfnCallback = new EDITSTREAMCALLBACK(OutEditStreamFunction);
            EDITSTREAM64 es64 = ConvertToEDITSTREAM64(es);
            SendMessage(this.Handle, RichtTextBoxConst.EM_STREAMOUT, RichtTextBoxConst.SF_RTF, es64);
            es.dwError = GetErrorValue64(es64);
            if (es.dwError != 0)
            {
                throw new InvalidOperationException("Unable to set RTF Text!");
            }

            User32.SendMessage(this.Handle, EditBoxMessages.EM_SETMODIFY, -1, 0);
            User32.SendMessage(this.Handle, EditBoxMessages.EM_GETLINECOUNT, 0, 0);
            
            _editStream.Dispose();

        }
        private Stream _editStream;
        private unsafe int OutEditStreamFunction(IntPtr dwCookie, IntPtr pbBuff, int cb, out int transferred)
        {
            int ret = 0;
            transferred = 0;
            byte[] buffer = new byte[cb];
            int cookieVal = (int)dwCookie;

            try
            {
                switch (cookieVal & DIRECTIONMASK)
                {
                    case OUTPUT:
                        {
                            if (_editStream == null)
                                _editStream = new MemoryStream();
                            switch (cookieVal & KINDMASK)
                            {
                                case RTF:
                                case TEXTCRLF:
                                    Marshal.Copy(pbBuff, buffer, 0, cb);
                                    _editStream.Write(buffer, 0, cb);
                                    break;
                                case TEXTLF:
                                    if ((cookieVal & UNICODE) != 0)
                                    {
                                        int requestedCharCount = cb / 2;
                                        int consumedCharCount = 0;

                                        fixed (byte* pb = buffer)
                                        {
                                            char* pChars = (char*)pb;
                                            char* pBuffer = (char*)(long)pbBuff;
                                            for (int i = 0; i < requestedCharCount; i++)
                                            {
                                                if (*pBuffer == (byte)'\r')
                                                {
                                                    pBuffer++;
                                                    continue;
                                                }

                                                *pChars = *pBuffer;
                                                pChars++;
                                                pBuffer++;
                                                consumedCharCount++;
                                            }
                                        }
                                        _editStream.Write(buffer, 0, consumedCharCount);
                                    }
                                    else
                                    {
                                        int requestedCharCount = cb;
                                        int consumedCharCount = 0;
                                        fixed (byte* pb = buffer)
                                        {
                                            byte* pChars = (byte*)pb;
                                            byte* pBuffer = (byte*)(long)pbBuff;

                                            for (int i = 0; i < requestedCharCount; i++)
                                            {
                                                if (*pBuffer == (byte)'\r')
                                                {
                                                    pBuffer++;
                                                    continue;
                                                }

                                                *pChars = *pBuffer;
                                                pChars++;
                                                pBuffer++;
                                                consumedCharCount++;
                                            }
                                        }
                                        _editStream.Write(buffer, 0, consumedCharCount);
                                    }
                                    break;
                            }
                        }
                        break;
                    case INPUT:
                        {
                            if (_editStream != null)
                            {
                                transferred = _editStream.Read(buffer, 0, cb);
                                Marshal.Copy(buffer, 0, pbBuff, transferred);
                                if (transferred < 0)
                                {
                                    transferred = 0;
                                }
                            }
                            else
                            {
                                transferred = 0;
                            }
                        }
                        break;
                }
            }
            catch (IOException )
            {
                transferred = 0;
                ret = 1;
            }
            transferred = cb;
            return ret;
        }

        public override string Text
        {
            get
            {
                if (this.Handle != IntPtr.Zero)
                {

                    int sz = this.GetByteCount();
                    GETTEXTEX gtx = new GETTEXTEX
                    {
                        cb = (uint)sz,
                        codepage = 1200,

                        flags = RichtTextBoxConst.GT_RAWTEXT,

                    };

                    string value = string.Empty;
                    using (var p = new ApiStructHandleRef<GETTEXTEX>(gtx))
                    {
                        IntPtr hg = Marshal.AllocHGlobal(sz);
                        byte[] arr = new byte[sz];
                        IntPtr result = User32.SendMessage(this.Handle, RichtTextBoxConst.EM_GETTEXTEX, p, hg);
                        int v = result.ToInt32();
                        Marshal.Copy(hg, arr, 0, sz);
                        Marshal.FreeHGlobal(hg);

                        value = Encoding.Unicode.GetString(arr);



                    }
                    return value;

                    //    IntPtr size = User32.SendMessage(this.Handle, WindowsMessages.WM_GETTEXTLENGTH, 0, 0);
                    //int len = size.ToInt32();
                    //StringBuilder sb = new StringBuilder(len + 1);
                    //User32.SendMessage(this.Handle, (int)WindowsMessages.WM_GETTEXT, sb.Capacity, sb);
                    //this._Text = sb.ToString();
                }
                return this._Text;
            }
            set
            {
                this._Text = value;
                if (this.Handle != IntPtr.Zero)
                {
                    SETTEXTEX stx = new SETTEXTEX
                    {
                        codepage = 1200,
                        flags = 0
                    };
                    IntPtr ptr = Marshal.AllocHGlobal(Marshal.SizeOf<SETTEXTEX>());
                    Marshal.StructureToPtr(stx, ptr, false);
                    User32.SendMessage(this.Handle, (int)RichtTextBoxConst.EM_SETTEXTEX, ptr, this._Text);
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        public override bool Create(IntPtr parentId)
        {
            bool retVal = base.Create(parentId);
            //User32.SendMessage(this.Handle, RichEditMessages.EM_EXLIMITTEXT, 0, uint.MaxValue);
            User32.SendMessage(this.Handle, (int)RichEditMessages.EM_SETTEXTMODE, 2, IntPtr.Zero);
            return retVal;

        }
    }
}