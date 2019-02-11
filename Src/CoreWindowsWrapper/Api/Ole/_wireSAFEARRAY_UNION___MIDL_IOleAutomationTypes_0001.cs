using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct _wireSAFEARRAY_UNION___MIDL_IOleAutomationTypes_0001
    {
        /// SAFEARR_BSTR->_wireSAFEARR_BSTR
        [FieldOffset(0)]
        public SAFEARR_BSTR BstrStr;

        /// SAFEARR_UNKNOWN->_wireSAFEARR_UNKNOWN
        [FieldOffset(0)]
        public SAFEARR_UNKNOWN UnknownStr;

        /// SAFEARR_DISPATCH->_wireSAFEARR_DISPATCH
        [FieldOffset(0)]
        public SAFEARR_DISPATCH DispatchStr;

        /// SAFEARR_VARIANT->_wireSAFEARR_VARIANT
        [FieldOffset(0)]
        public SAFEARR_VARIANT VariantStr;

        /// SAFEARR_BRECORD->_wireSAFEARR_BRECORD
        [FieldOffset(0)]
        public SAFEARR_BRECORD RecordStr;

        /// SAFEARR_HAVEIID->_wireSAFEARR_HAVEIID
        [FieldOffset(0)]
        public SAFEARR_HAVEIID HaveIidStr;

        /// BYTE_SIZEDARR->_BYTE_SIZEDARR
        [FieldOffset(0)]
        public BYTE_SIZEDARR ByteStr;

        /// WORD_SIZEDARR->_SHORT_SIZEDARR
        [FieldOffset(0)]
        public WORD_SIZEDARR WordStr;

        /// DWORD_SIZEDARR->_LONG_SIZEDARR
        [FieldOffset(0)]
        public DWORD_SIZEDARR LongStr;

        /// HYPER_SIZEDARR->_HYPER_SIZEDARR
        [FieldOffset(0)]
        public HYPER_SIZEDARR HyperStr;
    }
}