using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    internal interface IWindowClass
    {
        Wndclassex WindowClass { get; set; }
    }
}