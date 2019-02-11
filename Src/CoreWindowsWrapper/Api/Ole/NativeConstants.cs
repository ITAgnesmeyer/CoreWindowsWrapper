// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming
namespace CoreWindowsWrapper.Api.Ole
{
    public partial class NativeConstants
    {
        /// APPLICATION_VERIFIER_COM_UNBALANCED_OLEINIT -> 0x0404
        public const int APPLICATION_VERIFIER_COM_UNBALANCED_OLEINIT = 1028;

        /// MIXERCONTROL_CONTROLTYPE_BOOLEANMETER -> (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEANMETER = (MIXERCONTROL_CT_CLASS_METER
                                                                  | (MIXERCONTROL_CT_SC_METER_POLLED |
                                                                     MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// ERROR_DS_UNABLE_TO_SURRENDER_ROLES -> 8435L
        public const int ERROR_DS_UNABLE_TO_SURRENDER_ROLES = 8435;

        /// MIXERCONTROL_CT_SC_SWITCH_BOOLEAN -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_SWITCH_BOOLEAN = 0;

        /// ERROR_DS_SAM_INIT_FAILURE_CONSOLE -> 8562L
        public const int ERROR_DS_SAM_INIT_FAILURE_CONSOLE = 8562;

        /// MIXERCONTROL_CONTROLTYPE_BOOLEAN -> (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | MIXERCONTROL_CT_UNITS_BOOLEAN)
        public const int MIXERCONTROL_CONTROLTYPE_BOOLEAN = (MIXERCONTROL_CT_CLASS_SWITCH
                                                             | (MIXERCONTROL_CT_SC_SWITCH_BOOLEAN |
                                                                MIXERCONTROL_CT_UNITS_BOOLEAN));

        /// EVENT_CONSOLE_START_APPLICATION -> 0x4006
        public const int EVENT_CONSOLE_START_APPLICATION = 16390;

        /// MIXERCONTROL_CT_UNITS_BOOLEAN -> 0x00010000L
        public const int MIXERCONTROL_CT_UNITS_BOOLEAN = 65536;

        /// EVENT_CONSOLE_END_APPLICATION -> 0x4007
        public const int EVENT_CONSOLE_END_APPLICATION = 16391;

        /// ERROR_DS_INIT_FAILURE_CONSOLE -> 8561L
        public const int ERROR_DS_INIT_FAILURE_CONSOLE = 8561;

        /// ERROR_DS_INCORRECT_ROLE_OWNER -> 8210L
        public const int ERROR_DS_INCORRECT_ROLE_OWNER = 8210;

        /// CONSOLE_SELECTION_IN_PROGRESS -> 0x0001
        public const int CONSOLE_SELECTION_IN_PROGRESS = 1;

        /// ERROR_DS_REFUSING_FSMO_ROLES -> 8433L
        public const int ERROR_DS_REFUSING_FSMO_ROLES = 8433;

        /// ERROR_CTX_CONSOLE_DISCONNECT -> 7041L
        public const int ERROR_CTX_CONSOLE_DISCONNECT = 7041;

        /// WriteConsoleOutputCharacter -> WriteConsoleOutputCharacterW
        /// Error generating expression: Value WriteConsoleOutputCharacterW is not resolved
        public const string WriteConsoleOutputCharacter = "WriteConsoleOutputCharacterW";

        /// EVENT_CONSOLE_UPDATE_SIMPLE -> 0x4003
        public const int EVENT_CONSOLE_UPDATE_SIMPLE = 16387;

        /// EVENT_CONSOLE_UPDATE_SCROLL -> 0x4004
        public const int EVENT_CONSOLE_UPDATE_SCROLL = 16388;

        /// EVENT_CONSOLE_UPDATE_REGION -> 0x4002
        public const int EVENT_CONSOLE_UPDATE_REGION = 16386;

        /// ERROR_DS_INVALID_ROLE_OWNER -> 8366L
        public const int ERROR_DS_INVALID_ROLE_OWNER = 8366;

        /// CONSOLE_SELECTION_NOT_EMPTY -> 0x0002
        public const int CONSOLE_SELECTION_NOT_EMPTY = 2;

        /// CONSOLE_FULLSCREEN_HARDWARE -> 2
        public const int CONSOLE_FULLSCREEN_HARDWARE = 2;

        /// ReadConsoleOutputCharacter -> ReadConsoleOutputCharacterW
        /// Error generating expression: Value ReadConsoleOutputCharacterW is not resolved
        public const string ReadConsoleOutputCharacter = "ReadConsoleOutputCharacterW";

        /// FillConsoleOutputCharacter -> FillConsoleOutputCharacterW
        /// Error generating expression: Value FillConsoleOutputCharacterW is not resolved
        public const string FillConsoleOutputCharacter = "FillConsoleOutputCharacterW";

        /// ERROR_DS_ROLE_NOT_VERIFIED -> 8610L
        public const int ERROR_DS_ROLE_NOT_VERIFIED = 8610;

        /// ScrollConsoleScreenBuffer -> ScrollConsoleScreenBufferW
        /// Error generating expression: Value ScrollConsoleScreenBufferW is not resolved
        public const string ScrollConsoleScreenBuffer = "ScrollConsoleScreenBufferW";

        /// POWER_ACTION_LOCK_CONSOLE -> 0x20000000
        public const int POWER_ACTION_LOCK_CONSOLE = 536870912;

        /// GetConsoleAliasExesLength -> GetConsoleAliasExesLengthW
        /// Error generating expression: Value GetConsoleAliasExesLengthW is not resolved
        public const string GetConsoleAliasExesLength = "GetConsoleAliasExesLengthW";

        /// ERROR_INVALID_DOMAIN_ROLE -> 1354L
        public const int ERROR_INVALID_DOMAIN_ROLE = 1354;

        /// ERROR_CTX_CONSOLE_CONNECT -> 7042L
        public const int ERROR_CTX_CONSOLE_CONNECT = 7042;

        /// CONSOLE_APPLICATION_16BIT -> 0x0001
        public const int CONSOLE_APPLICATION_16BIT = 1;

        /// REG_WHOLE_HIVE_VOLATILE -> (0x00000001L)
        public const int REG_WHOLE_HIVE_VOLATILE = 1;

        /// GetConsoleAliasesLength -> GetConsoleAliasesLengthW
        /// Error generating expression: Value GetConsoleAliasesLengthW is not resolved
        public const string GetConsoleAliasesLength = "GetConsoleAliasesLengthW";

        /// CONSOLE_TEXTMODE_BUFFER -> 1
        public const int CONSOLE_TEXTMODE_BUFFER = 1;

        /// CONSOLE_MOUSE_SELECTION -> 0x0004
        public const int CONSOLE_MOUSE_SELECTION = 4;

        /// CONSOLE_CARET_SELECTION -> 0x0001
        public const int CONSOLE_CARET_SELECTION = 1;

        /// WTS_CONSOLE_DISCONNECT -> 0x2
        public const int WTS_CONSOLE_DISCONNECT = 2;

        /// ERROR_CTX_NOT_CONSOLE -> 7038L
        public const int ERROR_CTX_NOT_CONSOLE = 7038;

        /// CONSOLE_CARET_VISIBLE -> 0x0002
        public const int CONSOLE_CARET_VISIBLE = 2;

        /// EVENT_CONSOLE_LAYOUT -> 0x4005
        public const int EVENT_CONSOLE_LAYOUT = 16389;

        /// CONSOLE_NO_SELECTION -> 0x0000
        public const int CONSOLE_NO_SELECTION = 0;

        /// WTS_CONSOLE_CONNECT -> 0x1
        public const int WTS_CONSOLE_CONNECT = 1;

        /// szOID_ROLE_OCCUPANT -> "2.5.4.33"
        public const string szOID_ROLE_OCCUPANT = "2.5.4.33";

        /// STDOLE2_MINORVERNUM -> 0x0
        public const int STDOLE2_MINORVERNUM = 0;

        /// STDOLE2_MAJORVERNUM -> 0x2
        public const int STDOLE2_MAJORVERNUM = 2;

        /// SEE_MASK_NO_CONSOLE -> 0x00008000
        public const int SEE_MASK_NO_CONSOLE = 32768;

        /// GetConsoleAliasExes -> GetConsoleAliasExesW
        /// Error generating expression: Value GetConsoleAliasExesW is not resolved
        public const string GetConsoleAliasExes = "GetConsoleAliasExesW";

        /// EVENT_CONSOLE_CARET -> 0x4001
        public const int EVENT_CONSOLE_CARET = 16385;

        /// WriteConsoleOutput -> WriteConsoleOutputW
        /// Error generating expression: Value WriteConsoleOutputW is not resolved
        public const string WriteConsoleOutput = "WriteConsoleOutputW";

        /// STDOLE_MINORVERNUM -> 0x0
        public const int STDOLE_MINORVERNUM = 0;

        /// STDOLE_MAJORVERNUM -> 0x1
        public const int STDOLE_MAJORVERNUM = 1;

        /// CREATE_NEW_CONSOLE -> 0x00000010
        public const int CREATE_NEW_CONSOLE = 16;

        /// CONSOLE_MOUSE_DOWN -> 0x0008
        public const int CONSOLE_MOUSE_DOWN = 8;

        /// CONSOLE_FULLSCREEN -> 1
        public const int CONSOLE_FULLSCREEN = 1;

        /// WriteConsoleInput -> WriteConsoleInputW
        /// Error generating expression: Value WriteConsoleInputW is not resolved
        public const string WriteConsoleInput = "WriteConsoleInputW";

        /// ReadConsoleOutput -> ReadConsoleOutputW
        /// Error generating expression: Value ReadConsoleOutputW is not resolved
        public const string ReadConsoleOutput = "ReadConsoleOutputW";

        /// GetConsoleAliases -> GetConsoleAliasesW
        /// Error generating expression: Value GetConsoleAliasesW is not resolved
        public const string GetConsoleAliases = "GetConsoleAliasesW";

        /// WM_SPOOLERSTATUS -> 0x002A
        public const int WM_SPOOLERSTATUS = 42;

        /// ReadConsoleInput -> ReadConsoleInputW
        /// Error generating expression: Value ReadConsoleInputW is not resolved
        public const string ReadConsoleInput = "ReadConsoleInputW";

        /// PeekConsoleInput -> PeekConsoleInputW
        /// Error generating expression: Value PeekConsoleInputW is not resolved
        public const string PeekConsoleInput = "PeekConsoleInputW";

        /// FR_HIDEWHOLEWORD -> 0x00010000
        public const int FR_HIDEWHOLEWORD = 65536;

        /// SetConsoleTitle -> SetConsoleTitleW
        /// Error generating expression: Value SetConsoleTitleW is not resolved
        public const string SetConsoleTitle = "SetConsoleTitleW";

        /// GetConsoleTitle -> GetConsoleTitleW
        /// Error generating expression: Value GetConsoleTitleW is not resolved
        public const string GetConsoleTitle = "GetConsoleTitleW";

        /// GetConsoleAlias -> GetConsoleAliasW
        /// Error generating expression: Value GetConsoleAliasW is not resolved
        public const string GetConsoleAlias = "GetConsoleAliasW";

        /// AddConsoleAlias -> AddConsoleAliasW
        /// Error generating expression: Value AddConsoleAliasW is not resolved
        public const string AddConsoleAlias = "AddConsoleAliasW";

        /// RIDEV_NOLEGACY -> 0x00000030
        public const int RIDEV_NOLEGACY = 48;

        /// FR_NOWHOLEWORD -> 0x00001000
        public const int FR_NOWHOLEWORD = 4096;

        /// C2_RIGHTTOLEFT -> 0x0002
        public const int C2_RIGHTTOLEFT = 2;

        /// WriteConsole -> WriteConsoleW
        /// Error generating expression: Value WriteConsoleW is not resolved
        public const string WriteConsole = "WriteConsoleW";

        /// STDOLE2_LCID -> 0x0000
        public const int STDOLE2_LCID = 0;

        /// FR_WHOLEWORD -> 0x00000002
        public const int FR_WHOLEWORD = 2;

        /// STDOLE_LCID -> 0x0000
        public const int STDOLE_LCID = 0;

        /// ReadConsole -> ReadConsoleW
        /// Error generating expression: Value ReadConsoleW is not resolved
        public const string ReadConsole = "ReadConsoleW";

        /// RPC_IF_OLE -> 0x0002
        public const int RPC_IF_OLE = 2;

        /// OLEIVERB_DISCARDUNDOSTATE -> (-6L)
        public const int OLEIVERB_DISCARDUNDOSTATE = -6;

        /// OLEIVERB_INPLACEACTIVATE -> (-5L)
        public const int OLEIVERB_INPLACEACTIVATE = -5;

        /// OLECREATE_LEAVERUNNING -> 0x00000001
        public const int OLECREATE_LEAVERUNNING = 1;

        /// OLEIVERB_UIACTIVATE -> (-4L)
        public const int OLEIVERB_UIACTIVATE = -4;

        /// OLEIVERB_PRIMARY -> (0L)
        public const int OLEIVERB_PRIMARY = 0;

        /// OLEOBJ_S_FIRST -> 0x00040180L
        public const int OLEOBJ_S_FIRST = 262528;

        /// OLEOBJ_E_FIRST -> 0x80040180L
        public const int OLEOBJ_E_FIRST = -2147221120;

        /// OLEOBJ_S_LAST -> 0x0004018FL
        public const int OLEOBJ_S_LAST = 262543;

        /// OLEOBJ_E_LAST -> 0x8004018FL
        public const int OLEOBJ_E_LAST = -2147221105;

        /// OLEIVERB_SHOW -> (-1L)
        public const int OLEIVERB_SHOW = -1;

        /// OLEIVERB_OPEN -> (-2L)
        public const int OLEIVERB_OPEN = -2;

        /// OLEIVERB_HIDE -> (-3L)
        public const int OLEIVERB_HIDE = -3;

        /// MIXERCONTROL_CT_CLASS_METER -> 0x10000000L
        public const int MIXERCONTROL_CT_CLASS_METER = 268435456;

        /// MIXERCONTROL_CT_SC_METER_POLLED -> 0x00000000L
        public const int MIXERCONTROL_CT_SC_METER_POLLED = 0;

        /// MIXERCONTROL_CT_CLASS_SWITCH -> 0x20000000L
        public const int MIXERCONTROL_CT_CLASS_SWITCH = 536870912;
    }
}