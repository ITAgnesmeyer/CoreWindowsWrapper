using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_79fe9041_6876_475e_b93a_ffb0d7822836
    {
        /// KEY_EVENT_RECORD->_KEY_EVENT_RECORD
        [FieldOffset(0)]
        public KEY_EVENT_RECORD KeyEvent;

        /// MOUSE_EVENT_RECORD->_MOUSE_EVENT_RECORD
        [FieldOffset(0)]
        public MOUSE_EVENT_RECORD MouseEvent;

        /// WINDOW_BUFFER_SIZE_RECORD->_WINDOW_BUFFER_SIZE_RECORD
        [FieldOffset(0)]
        public WINDOW_BUFFER_SIZE_RECORD WindowBufferSizeEvent;

        /// MENU_EVENT_RECORD->_MENU_EVENT_RECORD
        [FieldOffset(0)]
        public MENU_EVENT_RECORD MenuEvent;

        /// FOCUS_EVENT_RECORD->_FOCUS_EVENT_RECORD
        [FieldOffset(0)]
        public FOCUS_EVENT_RECORD FocusEvent;
    }
}