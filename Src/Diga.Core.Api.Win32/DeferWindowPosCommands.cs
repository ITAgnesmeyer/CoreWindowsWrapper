// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    public enum DeferWindowPosCommands : uint
    {
        ///<Summary>Draws a frame (defined in the window's class description) around the window.</Summary>
        SWP_DRAWFRAME = 0x0020,

        ///<Summary>Sends a WM_NCCALCSIZE message to the window, even if the window's size is not being changed. If this flag is not specified, WM_NCCALCSIZE is sent only when the window's size is being changed.</Summary>
        SWP_FRAMECHANGED = 0x0020,

        ///<Summary>Hides the window.</Summary>
        SWP_HIDEWINDOW = 0x0080,

        ///<Summary>Does not activate the window. If this flag is not set, the window is activated and moved to the top of either the topmost or non-topmost group (depending on the setting of the hWndInsertAfter parameter).</Summary>
        SWP_NOACTIVATE = 0x0010,

        ///<Summary>Discards the entire contents of the client area. If this flag is not specified, the valid contents of the client area are saved and copied back into the client area after the window is sized or repositioned.</Summary>
        SWP_NOCOPYBITS = 0x0100,

        ///<Summary>Retains the current position (ignores the x and y parameters).</Summary>
        SWP_NOMOVE = 0x0002,

        ///<Summary>Does not change the owner window's position in the Z order.</Summary>
        SWP_NOOWNERZORDER = 0x0200,

        ///<Summary>Does not redraw changes. If this flag is set, no repainting of any kind occurs. This applies to the client area, the nonclient area (including the title bar and scroll bars), and any part of the parent window uncovered as a result of the window being moved. When this flag is set, the application must explicitly invalidate or redraw any parts of the window and parent window that need redrawing.</Summary>
        SWP_NOREDRAW = 0x0008,

        ///<Summary>Same as the SWP_NOOWNERZORDER flag.</Summary>
        SWP_NOREPOSITION = 0x0200,

        ///<Summary>Prevents the window from receiving the WM_WINDOWPOSCHANGING message.</Summary>
        SWP_NOSENDCHANGING = 0x0400,

        ///<Summary>Retains the current size (ignores the cx and cy parameters).</Summary>
        SWP_NOSIZE = 0x0001,

        ///<Summary>Retains the current Z order (ignores the hWndInsertAfter parameter).</Summary>
        SWP_NOZORDER = 0x0004,

        ///<Summary>Displays the window.</Summary>
        SWP_SHOWWINDOW = 0x0040
    };
}