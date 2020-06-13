// ReSharper disable InconsistentNaming

using System;

namespace Diga.Core.Api.Win32
{
    // EM_GETTEXTEX info; this struct is passed in the wparam of the message 
    public struct GetTextEx
    {
        public uint cb; // Count of bytes in the string
        public uint flags; // Flags (see the GT_XXX defines
        public uint codepage; // Code page for translation (CP_ACP for sys default,
        //  1200 for Unicode, -1 for control default)	
        
       
        public string lpDefaultChar; // Replacement for unmappable chars
//C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
//ORIGINAL LINE: bool * lpUsedDefChar;
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
        public bool lpUsedDefChar; // Pointer to flag set when def char used

      

        public GetTextEx(uint cb, uint flags, uint codepage, string lpDefaultChar, bool lpUsedDefChar)
        {
            this.cb = cb;
            this.flags = flags;
            this.codepage = codepage;
            this.lpDefaultChar = lpDefaultChar ?? throw new ArgumentNullException(nameof(lpDefaultChar));
            this.lpUsedDefChar = lpUsedDefChar;
        }
    }

}