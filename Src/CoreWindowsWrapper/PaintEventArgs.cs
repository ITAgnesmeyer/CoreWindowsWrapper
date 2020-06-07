using System;

namespace CoreWindowsWrapper
{
    [Serializable]
    public class PaintEventArgs : EventArgs
    {
        public PaintObject PaintObject{get;}

        public PaintEventArgs(PaintObject po)
        {
            this.PaintObject = po;
        }
    }
}