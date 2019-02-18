using CoreWindowsWrapper.Api.Win32;

namespace CoreWindowsWrapper
{
    public class NativeListBox : NativeControlBase
    {
        protected override void Initialize()
        {
            base.Initialize();
            this.TypeIdentifier = "listbox";
            this.ClientEdge = true;
            this.Style = this.Style | (int)WindowStyles.WS_VSCROLL | (int)WindowStyles.WS_HSCROLL | EditBoxStyles.ES_AUTOVSCROLL;

        }

        protected override void AfterCreate()
        {
            base.AfterCreate();

        }

        public void AddText(string textToAdd)
        {
            Win32Api.SendMessage(this.Handle, ListBoxMessages.LB_ADDSTRING, 0, textToAdd);
        }

        public void Clear()
        {
            Win32Api.SendMessage(this.Handle, ListBoxMessages.LB_RESETCONTENT, 0, 0);
        }
    }
}