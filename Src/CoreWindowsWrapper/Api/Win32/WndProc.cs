using System;

namespace CoreWindowsWrapper.Api.Win32
{
    delegate IntPtr WndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
}