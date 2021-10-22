using System;
using Diga.Core.Api.Win32;
// ReSharper disable CheckNamespace

namespace CoreWindowsWrapper.Win32ApiForm
{
    internal class Win32Dialog : IDisposable
    {
        public static ApiHandleRef InstanceHandle { get; set; } = IntPtr.Zero;
        public ApiHandleRef Handle { get; private set; } = IntPtr.Zero;
        public ApiHandleRef ParentHandle { get; set; } = IntPtr.Zero;
        
        public void Dispose()
        {
           
        }
    }
}