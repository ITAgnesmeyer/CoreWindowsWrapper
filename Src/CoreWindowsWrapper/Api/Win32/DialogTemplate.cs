using System;

namespace CoreWindowsWrapper.Api.Win32
{
    internal struct DialogTemplate
    {
        public DLGTEMPLATE header;
        public DLGITEMTEMPLATE[] items;

        public DialogTemplate(DLGTEMPLATE header, DLGITEMTEMPLATE[] items)
        {
            this.header = header;
            this.items = items ?? throw new ArgumentNullException(nameof(items));
        }
    }
}