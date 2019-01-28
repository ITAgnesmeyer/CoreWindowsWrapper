﻿using System;
// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Win32
{
    [Flags]
    internal enum MenuFlags : uint
    {
        MF_STRING = 0,
        MF_BYPOSITION = 0x400,
        MF_SEPARATOR = 0x800,
        MF_REMOVE = 0x1000,
    }
}