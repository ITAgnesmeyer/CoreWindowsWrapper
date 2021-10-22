using Diga.Core.Api.Win32;
using System;

namespace CoreWindowsWrapper
{
    public class NativeComboBoxSelChangeEventArgs : EventArgs
    {
        public int Index { get; }

        public NativeComboBoxSelChangeEventArgs(int index)
        {
            this.Index = index;
        }
    }
}