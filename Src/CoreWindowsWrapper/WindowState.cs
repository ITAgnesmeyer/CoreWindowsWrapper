using Diga.Core.Api.Win32;

namespace CoreWindowsWrapper
{
    public enum WindowState : int
    {
        Normal= 1,
        Minimized = ShowWindowCommands.Minimize,
        Maximized = 3
    }
}