using System;

namespace CoreWindowsWrapper
{
    public class NativeLinkClickEventArgs : EventArgs
    {
        public string Id { get;set; }
        public string Url{get;set;}

        public NativeLinkClickEventArgs(string id , string url)
        {
            this.Id = id;
            this.Url = url;
        }
    }
}