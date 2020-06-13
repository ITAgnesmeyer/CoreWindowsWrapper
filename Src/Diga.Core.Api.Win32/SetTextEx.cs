// ReSharper disable InconsistentNaming

namespace Diga.Core.Api.Win32
{
    // EM_SETTEXTEX info; this struct is passed in the wparam of the message 
    public class SetTextEx
    {
        public uint flags; // Flags (see the ST_XXX defines)
        public uint codepage; // Code page for translation (CP_ACP for sys default,
        //  1200 for Unicode, -1 for control default)	
    }

}