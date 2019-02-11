using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: HRESULT->LONG->int
    ///This: IOleInPlaceActiveObject*
    ///lpmsg: LPMSG->tagMSG*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate int IOleInPlaceActiveObjectVtbl_TranslateAcceleratorW(ref IOleInPlaceActiveObject This,
        ref tagMSG lpmsg);
}