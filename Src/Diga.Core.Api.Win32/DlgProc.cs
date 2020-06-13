using System;
using System.Runtime.InteropServices;

namespace Diga.Core.Api.Win32
{

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int DlgProc(IntPtr hWnd, uint param1, IntPtr wParam, IntPtr lParam);
  
}