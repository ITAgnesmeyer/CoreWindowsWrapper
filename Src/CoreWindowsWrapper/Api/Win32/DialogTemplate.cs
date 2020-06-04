using System;

namespace CoreWindowsWrapper.Api.Win32
{
    internal struct DialogTemplate
    {
        public DlgTemplate header;
        public DlgItemTemplate[] items;

        public DialogTemplate(DlgTemplate header, DlgItemTemplate[] items)
        {
            this.header = header;
            this.items = items ?? throw new ArgumentNullException(nameof(items));
        }
    }
}