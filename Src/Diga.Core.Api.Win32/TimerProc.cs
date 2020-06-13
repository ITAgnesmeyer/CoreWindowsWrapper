using System;
using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{

    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    public delegate void TimerProc(IntPtr param0, uint param1, IntPtr param2, uint param3);

}