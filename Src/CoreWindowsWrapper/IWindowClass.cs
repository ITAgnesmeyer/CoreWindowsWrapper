﻿using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    internal interface IWindowClass
    {
        WndclassEx WindowClass { get; set; }
    }
}