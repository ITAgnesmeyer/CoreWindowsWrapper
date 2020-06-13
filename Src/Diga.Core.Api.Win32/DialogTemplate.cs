using System;

namespace Diga.Core.Api.Win32
{
    public struct DialogTemplate
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