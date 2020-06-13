using System;
using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{
    /// Return Type: UINT_PTR->unsigned int
    ///param0: HWND->HWND__*
    ///param1: UINT->unsigned int
    ///param2: WPARAM->UINT_PTR->unsigned int
    ///param3: LPARAM->LONG_PTR->int
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate uint LpOfNHookProc(IntPtr param0, uint param1, IntPtr param2, IntPtr param3);
}