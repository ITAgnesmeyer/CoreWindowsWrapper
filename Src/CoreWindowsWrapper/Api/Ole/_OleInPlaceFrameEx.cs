using System;

namespace CoreWindowsWrapper.Api.Ole
{
    public interface  _OleInPlaceFrameEx:IOleInPlaceFrame
    {
        
        IntPtr Window{get;set;}
    }

}
