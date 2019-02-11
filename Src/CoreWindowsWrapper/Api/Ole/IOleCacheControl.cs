﻿using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IOleCacheControl
    {
        /// IOleCacheControlVtbl*
        public IntPtr lpVtbl;
    }
}