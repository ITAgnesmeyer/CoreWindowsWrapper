using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CoreWindowsWrapper.Api.Ole
{
    public partial class NativeMethods
    {
        
    /// Return Type: RPC_STATUS->int
    ///StringUuid: RPC_WSTR->unsigned short*
    ///Uuid: UUID*
    [DllImport("rpcrt4.dll", EntryPoint="UuidFromStringW", CallingConvention=System.Runtime.InteropServices.CallingConvention.StdCall)]
public static extern  int UuidFromString([System.Runtime.InteropServices.InAttribute()] System.IntPtr StringUuid, [System.Runtime.InteropServices.OutAttribute()] out GUID Uuid) ;


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_RemoteTranslateAccelerator_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_RemoteTranslateAccelerator_Proxy(
            ref IOleInPlaceActiveObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_RemoteTranslateAccelerator_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_RemoteTranslateAccelerator_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fActivate: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_OnFrameWindowActivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_OnFrameWindowActivate_Proxy(ref IOleInPlaceActiveObject This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fActivate);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///lpmsg: LPMSG->tagMSG*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_TranslateAccelerator_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_TranslateAccelerator_Proxy(ref IOleInPlaceActiveObject This,
            ref tagMSG lpmsg);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_OnFrameWindowActivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_OnFrameWindowActivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_TranslateAccelerator_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_TranslateAccelerator_Stub(ref IOleInPlaceActiveObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fActivate: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_OnDocWindowActivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_OnDocWindowActivate_Proxy(ref IOleInPlaceActiveObject This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fActivate);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///riid: IID*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_RemoteResizeBorder_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_RemoteResizeBorder_Proxy(ref IOleInPlaceActiveObject This,
            ref tagRECT prcBorder, ref GUID riid, ref IOleInPlaceUIWindow pUIWindow,
            [MarshalAs(UnmanagedType.Bool)]
            bool fFrameWindow);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_OnDocWindowActivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_OnDocWindowActivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_RemoteResizeBorder_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_RemoteResizeBorder_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_RequestBorderSpace_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_RequestBorderSpace_Proxy(ref IOleInPlaceUIWindow This,
            ref tagRECT pborderwidths);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///fEnable: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_EnableModeless_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_EnableModeless_Proxy(ref IOleInPlaceActiveObject This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fEnable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_RequestBorderSpace_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_RequestBorderSpace_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///lpmsg: LPMSG->tagMSG*
        ///wID: WORD->unsigned short
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_TranslateAccelerator_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_TranslateAccelerator_Proxy(ref IOleInPlaceFrame This,
            ref tagMSG lpmsg, ushort wID);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_EnableModeless_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceActiveObject_EnableModeless_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleClientSite_RequestNewObjectLayout_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_RequestNewObjectLayout_Proxy(ref IOleClientSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_TranslateAccelerator_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_TranslateAccelerator_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_ResizeBorder_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_ResizeBorder_Proxy(ref IOleInPlaceActiveObject This,
            ref tagRECT prcBorder, ref IOleInPlaceUIWindow pUIWindow,
            [MarshalAs(UnmanagedType.Bool)]
            bool fFrameWindow);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleClientSite_RequestNewObjectLayout_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_RequestNewObjectLayout_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pActiveObject: IOleInPlaceActiveObject*
        ///pszObjName: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_SetActiveObject_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_SetActiveObject_Proxy(ref IOleInPlaceUIWindow This,
            ref IOleInPlaceActiveObject pActiveObject, [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string pszObjName);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnInPlaceDeactivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnInPlaceDeactivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_ReactivateAndUndo_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_ReactivateAndUndo_Proxy(ref IOleInPlaceObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_InPlaceDeactivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_InPlaceDeactivate_Proxy(ref IOleInPlaceObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceActiveObject*
        ///prcBorder: LPCRECT->RECT*
        ///riid: IID*
        ///pUIWindow: IOleInPlaceUIWindow*
        ///fFrameWindow: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceActiveObject_ResizeBorder_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceActiveObject_ResizeBorder_Stub(ref IOleInPlaceActiveObject This,
            ref tagRECT prcBorder, ref GUID riid, ref IOleInPlaceUIWindow pUIWindow,
            [MarshalAs(UnmanagedType.Bool)]
            bool fFrameWindow);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        ///pbc: IBindCtx*
        ///riid: IID*
        ///ppvStorage: void**
        [DllImport("<Unknown>",
            EntryPoint = "IOleItemContainer_GetObjectStorage_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_GetObjectStorage_Proxy(ref IOleItemContainer This,
            IntPtr pszItem, ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvStorage);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///pborderwidths: LPCBORDERWIDTHS->LPCRECT->RECT*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_SetBorderSpace_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_SetBorderSpace_Proxy(ref IOleInPlaceUIWindow This,
            ref tagRECT pborderwidths);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_SetActiveObject_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_SetActiveObject_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnInPlaceDeactivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnInPlaceDeactivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_CanInPlaceActivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_CanInPlaceActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_ReactivateAndUndo_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_ReactivateAndUndo_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_InPlaceDeactivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_InPlaceDeactivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleItemContainer_GetObjectStorage_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_GetObjectStorage_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_SetBorderSpace_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_SetBorderSpace_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnInPlaceActivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnInPlaceActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_DeactivateAndUndo_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_DeactivateAndUndo_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_CanInPlaceActivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_CanInPlaceActivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnInPlaceActivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnInPlaceActivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///ppFrame: IOleInPlaceFrame**
        ///ppDoc: IOleInPlaceUIWindow**
        ///lprcPosRect: LPRECT->tagRECT*
        ///lprcClipRect: LPRECT->tagRECT*
        ///lpFrameInfo: LPOLEINPLACEFRAMEINFO->tagOIFI*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_GetWindowContext_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_GetWindowContext_Proxy(ref IOleInPlaceSite This,
            ref IntPtr ppFrame, ref IntPtr ppDoc, ref tagRECT lprcPosRect, ref tagRECT lprcClipRect,
            ref tagOIFI lpFrameInfo);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_DiscardUndoState_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_DiscardUndoState_Proxy(ref IOleInPlaceSite This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_DeactivateAndUndo_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_DeactivateAndUndo_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        ///lprcPosRect: LPCRECT->RECT*
        ///lprcClipRect: LPCRECT->RECT*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_SetObjectRects_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_SetObjectRects_Proxy(ref IOleInPlaceObject This,
            ref tagRECT lprcPosRect, ref tagRECT lprcClipRect);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleWindow*
        ///fEnterMode: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleWindow_ContextSensitiveHelp_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleWindow_ContextSensitiveHelp_Proxy(ref IOleWindow This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fEnterMode);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///lprcPosRect: LPCRECT->RECT*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnPosRectChange_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnPosRectChange_Proxy(ref IOleInPlaceSite This,
            ref tagRECT lprcPosRect);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_GetWindowContext_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_GetWindowContext_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_DiscardUndoState_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_DiscardUndoState_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_SetObjectRects_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_SetObjectRects_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///fEnable: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_EnableModeless_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_EnableModeless_Proxy(ref IOleInPlaceFrame This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fEnable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleWindow_ContextSensitiveHelp_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleWindow_ContextSensitiveHelp_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///fUndoable: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnUIDeactivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnUIDeactivate_Proxy(ref IOleInPlaceSite This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fUndoable);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnPosRectChange_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnPosRectChange_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceObject*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_UIDeactivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceObject_UIDeactivate_Proxy(ref IOleInPlaceObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///pszStatusText: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_SetStatusText_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_SetStatusText_Proxy(ref IOleInPlaceFrame This,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string pszStatusText);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_EnableModeless_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_EnableModeless_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pszStatusText: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>",
            EntryPoint = "IOleLink_SetSourceDisplayName_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetSourceDisplayName_Proxy(ref IOleLink This,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string pszStatusText);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppszDisplayName: LPOLESTR*
        [DllImport("<Unknown>",
            EntryPoint = "IOleLink_GetSourceDisplayName_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetSourceDisplayName_Proxy(ref IOleLink This,
            ref IntPtr ppszDisplayName);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceUIWindow*
        ///lprectBorder: LPRECT->tagRECT*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_GetBorder_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceUIWindow_GetBorder_Proxy(ref IOleInPlaceUIWindow This,
            ref tagRECT lprectBorder);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnUIDeactivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnUIDeactivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceObject_UIDeactivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceObject_UIDeactivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_SetStatusText_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_SetStatusText_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///pmk: IMoniker*
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_SendOnRename_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnRename_Proxy(ref IOleAdviseHolder This, ref IMoniker pmk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleLink_SetSourceDisplayName_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetSourceDisplayName_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleLink_GetSourceDisplayName_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetSourceDisplayName_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceUIWindow_GetBorder_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceUIWindow_GetBorder_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnUIActivate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_OnUIActivate_Proxy(ref IOleInPlaceSite This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_RemoveMenus_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_RemoveMenus_Proxy(ref IOleInPlaceFrame This,
            IntPtr hmenuShared);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        ///lpMenuWidths: LPOLEMENUGROUPWIDTHS->tagOleMenuGroupWidths*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_InsertMenus_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_InsertMenus_Proxy(ref IOleInPlaceFrame This,
            IntPtr hmenuShared, ref tagOleMenuGroupWidths lpMenuWidths);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LONG_PTR->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleCache2_RemoteUpdateCache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_RemoteUpdateCache_Proxy(ref IOleCache2 This, ref IDataObject pDataObject,
            uint grfUpdf,
            [MarshalAs(UnmanagedType.SysInt)]
            int pReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_SendOnRename_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnRename_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_SendOnClose_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnClose_Proxy(ref IOleAdviseHolder This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwReserved: DWORD->unsigned int
        ///ppDataObject: IDataObject**
        [DllImport("<Unknown>",
            EntryPoint = "IOleObject_GetClipboardData_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetClipboardData_Proxy(ref IOleObject This, uint dwReserved,
            ref IntPtr ppDataObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        [DllImport("<Unknown>",
            EntryPoint = "IOleItemContainer_IsRunning_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_IsRunning_Proxy(ref IOleItemContainer This, IntPtr pszItem);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleItemContainer*
        ///pszItem: LPOLESTR->OLECHAR*
        ///dwSpeedNeeded: DWORD->unsigned int
        ///pbc: IBindCtx*
        ///riid: IID*
        ///ppvObject: void**
        [DllImport("<Unknown>",
            EntryPoint = "IOleItemContainer_GetObject_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleItemContainer_GetObject_Proxy(ref IOleItemContainer This, IntPtr pszItem,
            uint dwSpeedNeeded, ref IBindCtx pbc, ref GUID riid, ref IntPtr ppvObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceSite_OnUIActivate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_OnUIActivate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_RemoveMenus_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_RemoveMenus_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleInPlaceFrame_InsertMenus_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_InsertMenus_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleContainer*
        ///fLock: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleContainer_LockContainer_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleContainer_LockContainer_Proxy(ref IOleContainer This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fLock);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///fShow: BOOL->int
        [DllImport("<Unknown>",
            EntryPoint = "IOleClientSite_OnShowWindow_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_OnShowWindow_Proxy(ref IOleClientSite This,
            [MarshalAs(UnmanagedType.Bool)]
            bool fShow);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///ppContainer: IOleContainer**
        [DllImport("<Unknown>",
            EntryPoint = "IOleClientSite_GetContainer_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_GetContainer_Proxy(ref IOleClientSite This,
            ref IntPtr ppContainer);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleCache2_RemoteUpdateCache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache2_RemoteUpdateCache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_SendOnSave_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_SendOnSave_Proxy(ref IOleAdviseHolder This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_SendOnClose_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnClose_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>",
            EntryPoint = "IOleAdviseHolder_EnumAdvise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_EnumAdvise_Proxy(ref IOleAdviseHolder This,
            ref IntPtr ppenumAdvise);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClipboardData_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetClipboardData_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_IsRunning_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_IsRunning_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleItemContainer_GetObject_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleItemContainer_GetObject_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_LockContainer_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleContainer_LockContainer_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_OnShowWindow_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_OnShowWindow_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetContainer_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_GetContainer_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_SendOnSave_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_SendOnSave_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_EnumAdvise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_EnumAdvise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pLogpal: LOGPALETTE*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetColorScheme_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetColorScheme_Proxy(ref IOleObject This, ref tagLOGPALETTE pLogpal);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pClsid: CLSID*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserClassID_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetUserClassID_Proxy(ref IOleObject This, ref GUID pClsid);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///dwUpdateOpt: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetUpdateOptions_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetUpdateOptions_Proxy(ref IOleLink This, uint dwUpdateOpt);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pmk: IMoniker*
        ///rclsid: IID*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceMoniker_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_SetSourceMoniker_Proxy(ref IOleLink This, ref IMoniker pmk, ref GUID rclsid);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pdwUpdateOpt: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetUpdateOptions_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetUpdateOptions_Proxy(ref IOleLink This, ref uint pdwUpdateOpt);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceMoniker_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetSourceMoniker_Proxy(ref IOleLink This, ref IntPtr ppmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleContainer*
        ///grfFlags: DWORD->unsigned int
        ///ppenum: IEnumUnknown**
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_EnumObjects_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleContainer_EnumObjects_Proxy(ref IOleContainer This, uint grfFlags,
            ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_ShowObject_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_ShowObject_Proxy(ref IOleClientSite This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_SaveObject_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_SaveObject_Proxy(ref IOleClientSite This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleClientSite*
        ///dwAssign: DWORD->unsigned int
        ///dwWhichMoniker: DWORD->unsigned int
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetMoniker_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleClientSite_GetMoniker_Proxy(ref IOleClientSite This, uint dwAssign,
            uint dwWhichMoniker, ref IntPtr ppmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Unadvise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_Unadvise_Proxy(ref IOleAdviseHolder This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetColorScheme_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetColorScheme_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pClientSite: IOleClientSite*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetClientSite_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetClientSite_Proxy(ref IOleObject This, ref IOleClientSite pClientSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserClassID_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetUserClassID_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwAspect: DWORD->unsigned int
        ///pdwStatus: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMiscStatus_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetMiscStatus_Proxy(ref IOleObject This, uint dwAspect, ref uint pdwStatus);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppClientSite: IOleClientSite**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClientSite_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetClientSite_Proxy(ref IOleObject This, ref IntPtr ppClientSite);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetUpdateOptions_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetUpdateOptions_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_SetSourceMoniker_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_SetSourceMoniker_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetUpdateOptions_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetUpdateOptions_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetSourceMoniker_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetSourceMoniker_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceFrame*
        ///hmenuShared: HMENU->HMENU__*
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hwndActiveObject: HWND->HWND__*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetMenu_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceFrame_SetMenu_Proxy(ref IOleInPlaceFrame This, IntPtr hmenuShared,
            IntPtr holemenu, IntPtr hwndActiveObject);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleContainer_EnumObjects_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleContainer_EnumObjects_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_ShowObject_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_ShowObject_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_SaveObject_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_SaveObject_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleClientSite_GetMoniker_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleClientSite_GetMoniker_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Unadvise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_Unadvise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///lpNumberOfMouseButtons: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint =
            "GetNumberOfConsoleMouseButtons")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleMouseButtons(ref uint lpNumberOfMouseButtons);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///szContainerApp: LPCOLESTR->OLECHAR*
        ///szContainerObj: LPCOLESTR->OLECHAR*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetHostNames_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetHostNames_Proxy(ref IOleObject This,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string szContainerApp, [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string szContainerObj);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetClientSite_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetClientSite_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pDataObject: IDataObject*
        ///fCreation: BOOL->int
        ///dwReserved: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_InitFromData_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_InitFromData_Proxy(ref IOleObject This, ref IDataObject pDataObject,
            [MarshalAs(UnmanagedType.Bool)]
            bool fCreation, uint dwReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMiscStatus_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetMiscStatus_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetClientSite_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetClientSite_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///ppunk: IUnknown**
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetBoundSource_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_GetBoundSource_Proxy(ref IOleLink This, ref IntPtr ppunk);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceFrame_SetMenu_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceFrame_SetMenu_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCacheControl*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnStop_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCacheControl_OnStop_Proxy(ref IOleCacheControl This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///dwDiscardOptions: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_DiscardCache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_DiscardCache_Proxy(ref IOleCache2 This, uint dwDiscardOptions);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleAdviseHolder*
        ///pAdvise: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Advise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleAdviseHolder_Advise_Proxy(ref IOleAdviseHolder This, ref IAdviseSink pAdvise,
            ref uint pdwConnection);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_RemoteNext_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_RemoteNext_Proxy(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt,
            ref uint pceltFetched);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpNumberOfEvents: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint =
            "GetNumberOfConsoleInputEvents")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, ref uint lpNumberOfEvents);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "WTSGetActiveConsoleSessionId")]
        public static extern uint WTSGetActiveConsoleSessionId();


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterW(IntPtr hConsoleOutput,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPCSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputCharacterA(IntPtr hConsoleOutput,
            [In()]
            [MarshalAs(UnmanagedType.LPStr)]
            string lpCharacter, uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleActiveScreenBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetHostNames_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetHostNames_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_InitFromData_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_InitFromData_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwFormOfType: DWORD->unsigned int
        ///pszUserType: LPOLESTR*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserType_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetUserType_Proxy(ref IOleObject This, uint dwFormOfType,
            ref IntPtr pszUserType);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_GetBoundSource_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_GetBoundSource_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindIfRunning_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_BindIfRunning_Proxy(ref IOleLink This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleInPlaceSite*
        ///scrollExtant: SIZE->tagSIZE
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_Scroll_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleInPlaceSite_Scroll_Proxy(ref IOleInPlaceSite This, tagSIZE scrollExtant);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnStop_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCacheControl_OnStop_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCacheControl*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnRun_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCacheControl_OnRun_Proxy(ref IOleCacheControl This, ref IDataObject pDataObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LPVOID->void*
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_UpdateCache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_UpdateCache_Proxy(ref IOleCache2 This, ref IDataObject pDataObject,
            uint grfUpdf, IntPtr pReserved);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_DiscardCache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache2_DiscardCache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleAdviseHolder_Advise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleAdviseHolder_Advise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_RemoteNext_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_RemoteNext_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: WORD*
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputAttribute(IntPtr hConsoleOutput, ref ushort lpAttribute,
            uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPWSTR->WCHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterW(IntPtr hConsoleOutput,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpCharacter: LPSTR->CHAR*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputCharacterA(IntPtr hConsoleOutput,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, ref uint lpNumberOfCharsRead);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwWhichMoniker: DWORD->unsigned int
        ///pmk: IMoniker*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetMoniker_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int
            IOleObject_SetMoniker_Proxy(ref IOleObject This, uint dwWhichMoniker, ref IMoniker pmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_IsUpToDate_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_IsUpToDate_Proxy(ref IOleObject This);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetUserType_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetUserType_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwAssign: DWORD->unsigned int
        ///dwWhichMoniker: DWORD->unsigned int
        ///ppmk: IMoniker**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMoniker_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetMoniker_Proxy(ref IOleObject This, uint dwAssign, uint dwWhichMoniker,
            ref IntPtr ppmk);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppenumAdvise: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumAdvise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_EnumAdvise_Proxy(ref IOleObject This, ref IntPtr ppenumAdvise);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_UnbindSource_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_UnbindSource_Proxy(ref IOleLink This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///bindflags: DWORD->unsigned int
        ///pbc: IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindToSource_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_BindToSource_Proxy(ref IOleLink This, uint bindflags, ref IBindCtx pbc);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindIfRunning_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_BindIfRunning_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleInPlaceSite_Scroll_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleInPlaceSite_Scroll_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCacheControl_OnRun_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCacheControl_OnRun_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache2*
        ///pDataObject: LPDATAOBJECT->IDataObject*
        ///grfUpdf: DWORD->unsigned int
        ///pReserved: LONG_PTR->int
        [DllImport("<Unknown>", EntryPoint = "IOleCache2_UpdateCache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache2_UpdateCache_Stub(ref IOleCache2 This, ref IDataObject pDataObject,
            uint grfUpdf,
            [MarshalAs(UnmanagedType.SysInt)]
            int pReserved);


        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "GetLargestConsoleWindowSize")]
        public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: WCHAR->wchar_t->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterW(IntPtr hConsoleOutput, char cCharacter,
            uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///cCharacter: CHAR->char
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputCharacterA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputCharacterA(IntPtr hConsoleOutput, byte cCharacter,
            uint nLength, COORD dwWriteCoord, ref uint lpNumberOfCharsWritten);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwSize: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleScreenBufferSize")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferW(IntPtr hConsoleOutput,
            ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin,
            ref CHAR_INFO lpFill);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpScrollRectangle: SMALL_RECT*
        ///lpClipRectangle: SMALL_RECT*
        ///dwDestinationOrigin: COORD->_COORD
        ///lpFill: CHAR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "ScrollConsoleScreenBufferA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ScrollConsoleScreenBufferA(IntPtr hConsoleOutput,
            ref SMALL_RECT lpScrollRectangle, ref SMALL_RECT lpClipRectangle, COORD dwDestinationOrigin,
            ref CHAR_INFO lpFill);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpAttribute: LPWORD->WORD*
        ///nLength: DWORD->unsigned int
        ///dwReadCoord: COORD->_COORD
        ///lpNumberOfAttrsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputAttribute(IntPtr hConsoleOutput, ref ushort lpAttribute,
            uint nLength, COORD dwReadCoord, ref uint lpNumberOfAttrsRead);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleWindow*
        ///phwnd: HWND*
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_GetWindow_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleWindow_GetWindow_Proxy(ref IOleWindow This, ref IntPtr phwnd);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetMoniker_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetMoniker_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///psizel: SIZEL*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetExtent_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_SetExtent_Proxy(ref IOleObject This, uint dwDrawAspect, ref tagSIZE psizel);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_IsUpToDate_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_IsUpToDate_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetMoniker_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetMoniker_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwDrawAspect: DWORD->unsigned int
        ///psizel: SIZEL*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetExtent_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_GetExtent_Proxy(ref IOleObject This, uint dwDrawAspect, ref tagSIZE psizel);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///ppEnumOleVerb: IEnumOLEVERB**
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumVerbs_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_EnumVerbs_Proxy(ref IOleObject This, ref IntPtr ppEnumOleVerb);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumAdvise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_EnumAdvise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_UnbindSource_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_UnbindSource_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_BindToSource_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_BindToSource_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleScreenBufferInfo: PCONSOLE_SCREEN_BUFFER_INFO->_CONSOLE_SCREEN_BUFFER_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleScreenBufferInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput,
            ref CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthW")]
        public static extern uint GetConsoleAliasExesLengthW();


        /// Return Type: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesLengthA")]
        public static extern uint GetConsoleAliasExesLengthA();


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttribute: WORD->unsigned short
        ///nLength: DWORD->unsigned int
        ///dwWriteCoord: COORD->_COORD
        ///lpNumberOfAttrsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "FillConsoleOutputAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FillConsoleOutputAttribute(IntPtr hConsoleOutput, ushort wAttribute,
            uint nLength, COORD dwWriteCoord, ref uint lpNumberOfAttrsWritten);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleWindow_GetWindow_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleWindow_GetWindow_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Unadvise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Unadvise_Proxy(ref IOleObject This, uint dwConnection);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_SetExtent_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_SetExtent_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_GetExtent_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_GetExtent_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_EnumVerbs_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_EnumVerbs_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pDataObject: IDataObject*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_InitCache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_InitCache_Proxy(ref IOleCache This, ref IDataObject pDataObject);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///ppenumSTATDATA: IEnumSTATDATA**
        [DllImport("<Unknown>", EntryPoint = "IOleCache_EnumCache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_EnumCache_Proxy(ref IOleCache This, ref IntPtr ppenumSTATDATA);


        /// Return Type: HANDLE->void*
        ///dwDesiredAccess: DWORD->unsigned int
        ///dwShareMode: DWORD->unsigned int
        ///lpSecurityAttributes: SECURITY_ATTRIBUTES*
        ///dwFlags: DWORD->unsigned int
        ///lpScreenBufferData: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "CreateConsoleScreenBuffer")]
        public static extern IntPtr CreateConsoleScreenBuffer(uint dwDesiredAccess, uint dwShareMode,
            ref SECURITY_ATTRIBUTES lpSecurityAttributes, uint dwFlags, IntPtr lpScreenBufferData);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///dwCursorPosition: COORD->_COORD
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorPosition")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Unadvise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Unadvise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_InitCache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_InitCache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_EnumCache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_EnumCache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Reset_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Reset_Proxy(ref IEnumOLEVERB This);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///ppenum: IEnumOLEVERB**
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Clone_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Clone_Proxy(ref IEnumOLEVERB This, ref IntPtr ppenum);


        /// Return Type: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthW")]
        public static extern uint GetConsoleAliasesLengthW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesLengthA")]
        public static extern uint GetConsoleAliasesLengthA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///dwCtrlEvent: DWORD->unsigned int
        ///dwProcessGroupId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GenerateConsoleCtrlEvent")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///wAttributes: WORD->unsigned short
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTextAttribute")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Update_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Update_Proxy(ref IOleObject This);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///iVerb: LONG->int
        ///lpmsg: LPMSG->tagMSG*
        ///pActiveSite: IOleClientSite*
        ///lindex: LONG->int
        ///hwndParent: HWND->HWND__*
        ///lprcPosRect: LPCRECT->RECT*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_DoVerb_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_DoVerb_Proxy(ref IOleObject This, int iVerb, ref tagMSG lpmsg,
            ref IOleClientSite pActiveSite, int lindex, IntPtr hwndParent, ref tagRECT lprcPosRect);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///pAdvSink: IAdviseSink*
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Advise_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Advise_Proxy(ref IOleObject This, ref IAdviseSink pAdvSink,
            ref uint pdwConnection);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///dwConnection: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Uncache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_Uncache_Proxy(ref IOleCache This, uint dwConnection);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pformatetc: FORMATETC*
        ///pmedium: STGMEDIUM*
        ///fRelease: BOOL->int
        [DllImport("<Unknown>", EntryPoint = "IOleCache_SetData_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_SetData_Proxy(ref IOleCache This, ref tagFORMATETC pformatetc,
            ref tagSTGMEDIUM pmedium,
            [MarshalAs(UnmanagedType.Bool)]
            bool fRelease);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Skip_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Skip_Proxy(ref IEnumOLEVERB This, uint celt);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Reset_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Reset_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Next_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Next_Proxy(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt,
            ref uint pceltFetched);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Clone_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Clone_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///lpConsoleSelectionInfo: PCONSOLE_SELECTION_INFO->_CONSOLE_SELECTION_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleSelectionInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleSelectionInfo(ref CONSOLE_SELECTION_INFO lpConsoleSelectionInfo);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        [DllImport("kernel32.dll", EntryPoint = "FlushConsoleInputBuffer")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Update_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Update_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_DoVerb_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_DoVerb_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleObject*
        ///dwSaveOption: DWORD->unsigned int
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Close_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleObject_Close_Proxy(ref IOleObject This, uint dwSaveOption);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Advise_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Advise_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Uncache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_Uncache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_SetData_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_SetData_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Skip_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IEnumOLEVERB_Skip_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IEnumOLEVERB*
        ///celt: ULONG->unsigned int
        ///rgelt: LPOLEVERB->tagOLEVERB*
        ///pceltFetched: ULONG*
        [DllImport("<Unknown>", EntryPoint = "IEnumOLEVERB_Next_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IEnumOLEVERB_Next_Stub(ref IEnumOLEVERB This, uint celt, ref tagOLEVERB rgelt,
            ref uint pceltFetched);


        /// Return Type: BOOL->int
        ///HandlerRoutine: PHANDLER_ROUTINE
        ///Add: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCtrlHandler")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCtrlHandler(PHANDLER_ROUTINE HandlerRoutine,
            [MarshalAs(UnmanagedType.Bool)]
            bool Add);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleObject_Close_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleObject_Close_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleLink*
        ///pbc: IBindCtx*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_Update_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleLink_Update_Proxy(ref IOleLink This, ref IBindCtx pbc);


        /// Return Type: HRESULT->LONG->int
        ///This: IOleCache*
        ///pformatetc: FORMATETC*
        ///advf: DWORD->unsigned int
        ///pdwConnection: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Cache_Proxy",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int IOleCache_Cache_Proxy(ref IOleCache This, ref tagFORMATETC pformatetc, uint advf,
            ref uint pdwConnection);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bMaximumWindow: BOOL->int
        ///lpConsoleCurrentFont: PCONSOLE_FONT_INFO->_CONSOLE_FONT_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentConsoleFont")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCurrentConsoleFont(IntPtr hConsoleOutput,
            [MarshalAs(UnmanagedType.Bool)]
            bool bMaximumWindow, ref CONSOLE_FONT_INFO lpConsoleCurrentFont);


        /// Return Type: DWORD->unsigned int
        ///lpdwProcessList: LPDWORD->DWORD*
        ///dwProcessCount: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleProcessList")]
        public static extern uint GetConsoleProcessList(ref uint lpdwProcessList, uint dwProcessCount);


        /// Return Type: BOOL->int
        ///lpModeFlags: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleDisplayMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleDisplayMode(ref uint lpModeFlags);


        /// Return Type: HRESULT->LONG->int
        ///ppOAHolder: LPOLEADVISEHOLDER*
        [DllImport("ole32.dll", EntryPoint = "CreateOleAdviseHolder",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int CreateOleAdviseHolder(ref IntPtr ppOAHolder);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///bAbsolute: BOOL->int
        ///lpConsoleWindow: SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleWindowInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput,
            [MarshalAs(UnmanagedType.Bool)]
            bool bAbsolute, ref SMALL_RECT lpConsoleWindow);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCursorInfo(IntPtr hConsoleOutput,
            ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleLink_Update_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleLink_Update_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: void
        ///This: IRpcStubBuffer*
        ///_pRpcChannelBuffer: IRpcChannelBuffer*
        ///_pRpcMessage: PRPC_MESSAGE->_RPC_MESSAGE*
        ///_pdwStubPhase: DWORD*
        [DllImport("<Unknown>", EntryPoint = "IOleCache_Cache_Stub",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void IOleCache_Cache_Stub(ref IRpcStubBuffer This,
            ref IRpcChannelBuffer _pRpcChannelBuffer, ref RPC_MESSAGE _pRpcMessage, ref uint _pdwStubPhase);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpConsoleCursorInfo: PCONSOLE_CURSOR_INFO->_CONSOLE_CURSOR_INFO*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCursorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleCursorInfo(IntPtr hConsoleOutput,
            ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);


        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPWSTR->WCHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesW")]
        public static extern uint GetConsoleAliasExesW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeNameBuffer, uint ExeNameBufferLength);


        /// Return Type: DWORD->unsigned int
        ///ExeNameBuffer: LPSTR->CHAR*
        ///ExeNameBufferLength: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasExesA")]
        public static extern uint GetConsoleAliasExesA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder ExeNameBuffer, uint ExeNameBufferLength);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer,
            COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpWriteRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer,
            COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpWriteRegion);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsWritten);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsWritten: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsWritten);


        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleOutputCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleOutputCP(uint wCodePageID);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputW(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer,
            COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: PCHAR_INFO->_CHAR_INFO*
        ///dwBufferSize: COORD->_COORD
        ///dwBufferCoord: COORD->_COORD
        ///lpReadRegion: PSMALL_RECT->_SMALL_RECT*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleOutputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleOutputA(IntPtr hConsoleOutput, ref CHAR_INFO lpBuffer,
            COORD dwBufferSize, COORD dwBufferCoord, ref SMALL_RECT lpReadRegion);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleOutputCP")]
        public static extern uint GetConsoleOutputCP();


        /// Return Type: COORD->_COORD
        ///hConsoleOutput: HANDLE->void*
        ///nFont: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleFontSize")]
        public static extern COORD GetConsoleFontSize(IntPtr hConsoleOutput, uint nFont);


        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPWSTR->WCHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesW")]
        public static extern uint GetConsoleAliasesW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder AliasBuffer, uint AliasBufferLength,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///AliasBuffer: LPSTR->CHAR*
        ///AliasBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasesA")]
        public static extern uint GetConsoleAliasesA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder AliasBuffer, uint AliasBufferLength,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputW(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: PINPUT_RECORD->_INPUT_RECORD*
        ///nLength: DWORD->unsigned int
        ///lpNumberOfEventsRead: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "PeekConsoleInputA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PeekConsoleInputA(IntPtr hConsoleInput, ref INPUT_RECORD lpBuffer,
            uint nLength, ref uint lpNumberOfEventsRead);


        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleW(
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpConsoleTitle);


        /// Return Type: BOOL->int
        ///lpConsoleTitle: LPCSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleTitleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleTitleA(
            [In()]
            [MarshalAs(UnmanagedType.LPStr)]
            string lpConsoleTitle);


        /// Return Type: HWND->HWND__*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
        public static extern IntPtr GetConsoleWindow();


        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPWSTR->WCHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleW")]
        public static extern uint GetConsoleTitleW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder lpConsoleTitle, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///lpConsoleTitle: LPSTR->CHAR*
        ///nSize: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleTitleA")]
        public static extern uint GetConsoleTitleA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder lpConsoleTitle, uint nSize);


        /// Return Type: DWORD->unsigned int
        ///Source: LPWSTR->WCHAR*
        ///TargetBuffer: LPWSTR->WCHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasW")]
        public static extern uint GetConsoleAliasW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder Source,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder TargetBuffer, uint TargetBufferLength,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeName);


        /// Return Type: DWORD->unsigned int
        ///Source: LPSTR->CHAR*
        ///TargetBuffer: LPSTR->CHAR*
        ///TargetBufferLength: DWORD->unsigned int
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleAliasA")]
        public static extern uint GetConsoleAliasA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder Source,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder TargetBuffer, uint TargetBufferLength,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///Source: LPWSTR->WCHAR*
        ///Target: LPWSTR->WCHAR*
        ///ExeName: LPWSTR->WCHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasW(
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder Source,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder Target,
            [MarshalAs(UnmanagedType.LPWStr)]
            StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///Source: LPSTR->CHAR*
        ///Target: LPSTR->CHAR*
        ///ExeName: LPSTR->CHAR*
        [DllImport("kernel32.dll", EntryPoint = "AddConsoleAliasA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AddConsoleAliasA(
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder Source,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder Target,
            [MarshalAs(UnmanagedType.LPStr)]
            StringBuilder ExeName);


        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///dwMode: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);


        /// Return Type: void*
        ///Size: size_t->unsigned int
        [DllImport("rpcrt4.dll", EntryPoint = "NdrOleAllocate",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr NdrOleAllocate(
            [MarshalAs(UnmanagedType.SysUInt)]
            uint Size);


        /// Return Type: BOOL->int
        ///hConsoleHandle: HANDLE->void*
        ///lpMode: LPDWORD->DWORD*
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleMode")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetConsoleMode(IntPtr hConsoleHandle, ref uint lpMode);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleW(IntPtr hConsoleOutput, IntPtr lpBuffer,
            uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///hConsoleOutput: HANDLE->void*
        ///lpBuffer: void*
        ///nNumberOfCharsToWrite: DWORD->unsigned int
        ///lpNumberOfCharsWritten: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "WriteConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteConsoleA(IntPtr hConsoleOutput, IntPtr lpBuffer,
            uint nNumberOfCharsToWrite, ref uint lpNumberOfCharsWritten, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///rclsid: IID*
        [DllImport("ole32.dll", EntryPoint = "CoIsOle1Class",
            CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CoIsOle1Class(ref GUID rclsid);


        /// Return Type: BOOL->int
        ///dwProcessId: DWORD->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "AttachConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AttachConsole(uint dwProcessId);


        /// Return Type: BOOL->int
        ///wCodePageID: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "SetConsoleCP")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetConsoleCP(uint wCodePageID);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleW")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleW(IntPtr hConsoleInput, IntPtr lpBuffer,
            uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);


        /// Return Type: BOOL->int
        ///hConsoleInput: HANDLE->void*
        ///lpBuffer: LPVOID->void*
        ///nNumberOfCharsToRead: DWORD->unsigned int
        ///lpNumberOfCharsRead: LPDWORD->DWORD*
        ///lpReserved: LPVOID->void*
        [DllImport("kernel32.dll", EntryPoint = "ReadConsoleA")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadConsoleA(IntPtr hConsoleInput, IntPtr lpBuffer,
            uint nNumberOfCharsToRead, ref uint lpNumberOfCharsRead, IntPtr lpReserved);


        /// Return Type: UINT->unsigned int
        [DllImport("kernel32.dll", EntryPoint = "GetConsoleCP")]
        public static extern uint GetConsoleCP();


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();


        /// Return Type: BOOL->int
        [DllImport("kernel32.dll", EntryPoint = "FreeConsole")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeConsole();


        /// Return Type: void
        ///NodeToFree: void*
        [DllImport("rpcrt4.dll", EntryPoint = "NdrOleFree",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void NdrOleFree(IntPtr NodeToFree);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///hIcon: HICON->HICON__*
        ///lpszLabel: LPOLESTR->OLECHAR*
        ///lpszSourceFile: LPOLESTR->OLECHAR*
        ///iIconIndex: UINT->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleMetafilePictFromIconAndLabel",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleMetafilePictFromIconAndLabel(IntPtr hIcon, IntPtr lpszLabel,
            IntPtr lpszSourceFile, uint iIconIndex);


        /// Return Type: HRESULT->LONG->int
        ///polestm: LPOLESTREAM->_OLESTREAM*
        ///pstg: LPSTORAGE->IStorage*
        ///pcfFormat: CLIPFORMAT*
        ///plwWidth: LONG*
        ///plHeight: LONG*
        ///pdwSize: DWORD*
        ///pmedium: LPSTGMEDIUM->STGMEDIUM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertOLESTREAMToIStorageEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertOLESTREAMToIStorageEx(ref OLESTREAM polestm, ref IStorage pstg,
            ref ushort pcfFormat, ref int plwWidth, ref int plHeight, ref uint pdwSize, ref tagSTGMEDIUM pmedium);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///cfFormat: CLIPFORMAT->WORD->unsigned short
        ///lWidth: LONG->int
        ///lHeight: LONG->int
        ///dwSize: DWORD->unsigned int
        ///pmedium: LPSTGMEDIUM->STGMEDIUM*
        ///polestm: LPOLESTREAM->_OLESTREAM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertIStorageToOLESTREAMEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertIStorageToOLESTREAMEx(ref IStorage pstg, ushort cfFormat, int lWidth,
            int lHeight, uint dwSize, ref tagSTGMEDIUM pmedium, ref OLESTREAM polestm);


        /// Return Type: HRESULT->LONG->int
        ///lpolestream: LPOLESTREAM->_OLESTREAM*
        ///pstg: LPSTORAGE->IStorage*
        ///ptd: DVTARGETDEVICE*
        [DllImport("ole32.dll", EntryPoint = "OleConvertOLESTREAMToIStorage",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertOLESTREAMToIStorage(ref OLESTREAM lpolestream, ref IStorage pstg,
            ref tagDVTARGETDEVICE ptd);


        /// Return Type: HRESULT->LONG->int
        ///pstg: LPSTORAGE->IStorage*
        ///lpolestream: LPOLESTREAM->_OLESTREAM*
        [DllImport("ole32.dll", EntryPoint = "OleConvertIStorageToOLESTREAM",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleConvertIStorageToOLESTREAM(ref IStorage pstg, ref OLESTREAM lpolestream);


        /// Return Type: HRESULT->LONG->int
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        [DllImport("ole32.dll", EntryPoint = "OleDestroyMenuDescriptor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDestroyMenuDescriptor(IntPtr holemenu);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///flags: DWORD->unsigned int
        ///pCF: LPCLASSFACTORY->IClassFactory*
        ///riid: IID*
        ///lplpObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateEmbeddingHelper",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateEmbeddingHelper(ref GUID clsid, ref IUnknown pUnkOuter, uint flags,
            ref IClassFactory pCF, ref GUID riid, ref IntPtr lplpObj);


        /// Return Type: HRESULT->LONG->int
        ///lpFrame: LPOLEINPLACEFRAME->IOleInPlaceFrame*
        ///lpFrameInfo: LPOLEINPLACEFRAMEINFO->tagOIFI*
        ///lpmsg: LPMSG->tagMSG*
        [DllImport("ole32.dll", EntryPoint = "OleTranslateAccelerator",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleTranslateAccelerator(ref IOleInPlaceFrame lpFrame, ref tagOIFI lpFrameInfo,
            ref tagMSG lpmsg);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///iid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateStaticFromData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateStaticFromData(ref IDataObject pSrcDataObj, ref GUID iid, uint renderopt,
            ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hmenuCombined: HMENU->HMENU__*
        ///lpMenuWidths: LPOLEMENUGROUPWIDTHS->tagOleMenuGroupWidths*
        [DllImport("ole32.dll", EntryPoint = "OleCreateMenuDescriptor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleCreateMenuDescriptor(IntPtr hmenuCombined,
            ref tagOleMenuGroupWidths lpMenuWidths);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkFromDataEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkFromDataEx(ref IDataObject pSrcDataObj, ref GUID riid, uint dwFlags,
            uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink,
            ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///pUnkOuter: LPUNKNOWN->IUnknown*
        ///riid: IID*
        ///lplpObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateDefaultHandler",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateDefaultHandler(ref GUID clsid, ref IUnknown pUnkOuter, ref GUID riid,
            ref IntPtr lplpObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleQueryCreateFromData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleQueryCreateFromData(ref IDataObject pSrcDataObject);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fContained: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleSetContainedObject",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetContainedObject(ref IUnknown pUnknown,
            [MarshalAs(UnmanagedType.Bool)]
            bool fContained);


        /// Return Type: HRESULT->LONG->int
        ///pDataObj: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleIsCurrentClipboard",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleIsCurrentClipboard(ref IDataObject pDataObj);


        /// Return Type: HRESULT->LONG->int
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkToFileEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkToFileEx(
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpszFileName, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf,
            ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection,
            ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkFromData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkFromData(ref IDataObject pSrcDataObj, ref GUID riid, uint renderopt,
            ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///holemenu: HOLEMENU->HGLOBAL->HANDLE->void*
        ///hwndFrame: HWND->HWND__*
        ///hwndActiveObject: HWND->HWND__*
        ///lpFrame: LPOLEINPLACEFRAME->IOleInPlaceFrame*
        ///lpActiveObj: LPOLEINPLACEACTIVEOBJECT->IOleInPlaceActiveObject*
        [DllImport("ole32.dll", EntryPoint = "OleSetMenuDescriptor",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetMenuDescriptor(IntPtr holemenu, IntPtr hwndFrame,
            IntPtr hwndActiveObject, ref IOleInPlaceFrame lpFrame, ref IOleInPlaceActiveObject lpActiveObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObject: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleQueryLinkFromData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleQueryLinkFromData(ref IDataObject pSrcDataObject);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fVisible: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleNoteObjectVisible",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleNoteObjectVisible(ref IUnknown pUnknown,
            [MarshalAs(UnmanagedType.Bool)]
            bool fVisible);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwAspect: DWORD->unsigned int
        ///pdwStatus: DWORD*
        [DllImport("ole32.dll", EntryPoint = "OleRegGetMiscStatus",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegGetMiscStatus(ref GUID clsid, uint dwAspect, ref uint pdwStatus);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwDirection: DWORD->unsigned int
        ///ppenum: LPENUMFORMATETC*
        [DllImport("ole32.dll", EntryPoint = "OleRegEnumFormatEtc",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegEnumFormatEtc(ref GUID clsid, uint dwDirection, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkToFile",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkToFile(
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpszFileName, ref GUID riid, uint renderopt, ref tagFORMATETC lpFormatEtc,
            ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromFileEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromFileEx(ref GUID rclsid,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpszFileName, ref GUID riid, uint dwFlags, uint renderopt, uint cFormats, ref uint rgAdvf,
            ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink, ref uint rgdwConnection,
            ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromDataEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromDataEx(ref IDataObject pSrcDataObj, ref GUID riid, uint dwFlags,
            uint renderopt, uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink,
            ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///clsidNew: IID*
        [DllImport("ole32.dll", EntryPoint = "OleSetAutoConvert",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetAutoConvert(ref GUID clsidOld, ref GUID clsidNew);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///dwFormOfType: DWORD->unsigned int
        ///pszUserType: LPOLESTR*
        [DllImport("ole32.dll", EntryPoint = "OleRegGetUserType",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegGetUserType(ref GUID clsid, uint dwFormOfType, ref IntPtr pszUserType);


        /// Return Type: HRESULT->LONG->int
        ///pStm: LPSTREAM->IStream*
        ///iidInterface: IID*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleLoadFromStream",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLoadFromStream(ref IStream pStm, ref GUID iidInterface, ref IntPtr ppvObj);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///rclsid: IID*
        ///lpszLabel: LPOLESTR->OLECHAR*
        ///fUseTypeAsLabel: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleGetIconOfClass",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleGetIconOfClass(ref GUID rclsid, IntPtr lpszLabel,
            [MarshalAs(UnmanagedType.Bool)]
            bool fUseTypeAsLabel);


        /// Return Type: HRESULT->LONG->int
        ///clsidOld: IID*
        ///pClsidNew: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "OleGetAutoConvert",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleGetAutoConvert(ref GUID clsidOld, ref GUID pClsidNew);


        /// Return Type: HRESULT->LONG->int
        [DllImport("ole32.dll", EntryPoint = "OleFlushClipboard",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleFlushClipboard();


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///lpszFileName: LPCOLESTR->OLECHAR*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromFile",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromFile(ref GUID rclsid,
            [In()]
            [MarshalAs(UnmanagedType.LPWStr)]
            string lpszFileName, ref GUID riid, uint renderopt, ref tagFORMATETC lpFormatEtc,
            ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pSrcDataObj: LPDATAOBJECT->IDataObject*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateFromData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateFromData(ref IDataObject pSrcDataObj, ref GUID riid, uint renderopt,
            ref tagFORMATETC pFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HGLOBAL->HANDLE->void*
        ///lpszPath: LPOLESTR->OLECHAR*
        ///fUseFileAsLabel: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleGetIconOfFile",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleGetIconOfFile(IntPtr lpszPath,
            [MarshalAs(UnmanagedType.Bool)]
            bool fUseFileAsLabel);


        /// Return Type: HANDLE->void*
        ///hSrc: HANDLE->void*
        ///cfFormat: CLIPFORMAT->WORD->unsigned short
        ///uiFlags: UINT->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleDuplicateData",
            CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr OleDuplicateData(IntPtr hSrc, ushort cfFormat, uint uiFlags);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///pClsidNew: LPCLSID->CLSID*
        [DllImport("ole32.dll", EntryPoint = "OleDoAutoConvert",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDoAutoConvert(ref IStorage pStg, ref GUID pClsidNew);


        /// Return Type: void
        [DllImport("ole32.dll", EntryPoint = "OleUninitialize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern void OleUninitialize();


        /// Return Type: HRESULT->LONG->int
        ///pDataObj: LPDATAOBJECT->IDataObject*
        [DllImport("ole32.dll", EntryPoint = "OleSetClipboard",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSetClipboard(ref IDataObject pDataObj);


        /// Return Type: HRESULT->LONG->int
        ///pPStm: LPPERSISTSTREAM->IPersistStream*
        ///pStm: LPSTREAM->IStream*
        [DllImport("ole32.dll", EntryPoint = "OleSaveToStream",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSaveToStream(ref IPersistStream pPStm, ref IStream pStm);


        /// Return Type: HRESULT->LONG->int
        ///clsid: IID*
        ///ppenum: LPENUMOLEVERB*
        [DllImport("ole32.dll", EntryPoint = "OleRegEnumVerbs",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRegEnumVerbs(ref GUID clsid, ref IntPtr ppenum);


        /// Return Type: HRESULT->LONG->int
        ///ppDataObj: LPDATAOBJECT*
        [DllImport("ole32.dll", EntryPoint = "OleGetClipboard",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleGetClipboard(ref IntPtr ppDataObj);


        /// Return Type: HRESULT->LONG->int
        ///pmkLinkSrc: LPMONIKER->IMoniker*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLinkEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLinkEx(ref IMoniker pmkLinkSrc, ref GUID riid, uint dwFlags, uint renderopt,
            uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink,
            ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: DWORD->unsigned int
        [DllImport("ole32.dll", EntryPoint = "OleBuildVersion",
            CallingConvention = CallingConvention.StdCall)]
        public static extern uint OleBuildVersion();


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///fLock: BOOL->int
        ///fLastUnlockCloses: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleLockRunning",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLockRunning(ref IUnknown pUnknown,
            [MarshalAs(UnmanagedType.Bool)]
            bool fLock, [MarshalAs(UnmanagedType
                .Bool)]
            bool fLastUnlockCloses);


        /// Return Type: HRESULT->LONG->int
        ///pvReserved: LPVOID->void*
        [DllImport("ole32.dll", EntryPoint = "OleInitialize",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleInitialize(IntPtr pvReserved);


        /// Return Type: HRESULT->LONG->int
        ///pmkLinkSrc: LPMONIKER->IMoniker*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///lpFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateLink",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateLink(ref IMoniker pmkLinkSrc, ref GUID riid, uint renderopt,
            ref tagFORMATETC lpFormatEtc, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: BOOL->int
        ///pObject: LPOLEOBJECT->IOleObject*
        [DllImport("ole32.dll", EntryPoint = "OleIsRunning",
            CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OleIsRunning(ref IOleObject pObject);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///riid: IID*
        ///dwFlags: DWORD->unsigned int
        ///renderopt: DWORD->unsigned int
        ///cFormats: ULONG->unsigned int
        ///rgAdvf: DWORD*
        ///rgFormatEtc: LPFORMATETC->tagFORMATETC*
        ///lpAdviseSink: IAdviseSink*
        ///rgdwConnection: DWORD*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreateEx",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreateEx(ref GUID rclsid, ref GUID riid, uint dwFlags, uint renderopt,
            uint cFormats, ref uint rgAdvf, ref tagFORMATETC rgFormatEtc, ref IAdviseSink lpAdviseSink,
            ref uint rgdwConnection, ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///rclsid: IID*
        ///riid: IID*
        ///renderopt: DWORD->unsigned int
        ///pFormatEtc: LPFORMATETC->tagFORMATETC*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///pStg: LPSTORAGE->IStorage*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleCreate",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleCreate(ref GUID rclsid, ref GUID riid, uint renderopt, ref tagFORMATETC pFormatEtc,
            ref IOleClientSite pClientSite, ref IStorage pStg, ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pPS: LPPERSISTSTORAGE->IPersistStorage*
        ///pStg: LPSTORAGE->IStorage*
        ///fSameAsLoad: BOOL->int
        [DllImport("ole32.dll", EntryPoint = "OleSave",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleSave(ref IPersistStorage pPS, ref IStorage pStg,
            [MarshalAs(UnmanagedType.Bool)]
            bool fSameAsLoad);


        /// Return Type: HRESULT->LONG->int
        ///pStg: LPSTORAGE->IStorage*
        ///riid: IID*
        ///pClientSite: LPOLECLIENTSITE->IOleClientSite*
        ///ppvObj: LPVOID*
        [DllImport("ole32.dll", EntryPoint = "OleLoad",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleLoad(ref IStorage pStg, ref GUID riid, ref IOleClientSite pClientSite,
            ref IntPtr ppvObj);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        ///dwAspect: DWORD->unsigned int
        ///hdcDraw: HDC->HDC__*
        ///lprcBounds: LPCRECT->RECT*
        [DllImport("ole32.dll", EntryPoint = "OleDraw",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleDraw(ref IUnknown pUnknown, uint dwAspect, IntPtr hdcDraw,
            ref tagRECT lprcBounds);


        /// Return Type: HRESULT->LONG->int
        ///pUnknown: LPUNKNOWN->IUnknown*
        [DllImport("ole32.dll", EntryPoint = "OleRun",
            CallingConvention = CallingConvention.StdCall)]
        public static extern int OleRun(ref IUnknown pUnknown);
    }
}