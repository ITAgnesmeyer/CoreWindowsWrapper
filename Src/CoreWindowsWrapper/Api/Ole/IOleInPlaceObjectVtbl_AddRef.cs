﻿using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    /// Return Type: ULONG->unsigned int
    ///This: IOleInPlaceObject*
    [UnmanagedFunctionPointer(CallingConvention
        .StdCall)]
    public delegate uint IOleInPlaceObjectVtbl_AddRef(ref IOleInPlaceObject This);
}