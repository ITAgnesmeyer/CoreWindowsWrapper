using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Local

namespace Diga.Core.Api.Win32
{
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Auto)]
    public struct ComboboxInfo 
    {
    
        /// DWORD->unsigned int
        public uint cbSize;
    
        /// RECT->tagRECT
        public Rect rcItem;
    
        /// RECT->tagRECT
        public Rect rcButton;
    
        /// DWORD->unsigned int
        public uint stateButton;
    
        /// HWND->HWND__*
        public IntPtr hwndCombo;
    
        /// HWND->HWND__*
        public IntPtr hwndItem;
    
        /// HWND->HWND__*
        public IntPtr hwndList;
    }

}


