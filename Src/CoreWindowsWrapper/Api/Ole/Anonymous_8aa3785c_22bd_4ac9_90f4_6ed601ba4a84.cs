using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_8aa3785c_22bd_4ac9_90f4_6ed601ba4a84
    {
        /// LONGLONG->__int64
        [FieldOffset(0)]
        public long llVal;

        /// LONG->int
        [FieldOffset(0)]
        public int lVal;

        /// BYTE->unsigned char
        [FieldOffset(0)]
        public byte bVal;

        /// SHORT->short
        [FieldOffset(0)]
        public short iVal;

        /// FLOAT->float
        [FieldOffset(0)]
        public float fltVal;

        /// DOUBLE->double
        [FieldOffset(0)]
        public double dblVal;

        /// VARIANT_BOOL->short
        [FieldOffset(0)]
        public short boolVal;

        /// SCODE->LONG->int
        [FieldOffset(0)]
        public int scode;

        /// CY->tagCY
        [FieldOffset(0)]
        public tagCY cyVal;

        /// DATE->double
        [FieldOffset(0)]
        public double date;

        /// BSTR->OLECHAR*
        [FieldOffset(0)]
        public IntPtr bstrVal;

        /// IUnknown*
        [FieldOffset(0)]
        public IntPtr punkVal;

        /// IDispatch*
        [FieldOffset(0)]
        public IntPtr pdispVal;

        /// SAFEARRAY*
        [FieldOffset(0)]
        public IntPtr parray;

        /// BYTE*
        [FieldOffset(0)]
        public IntPtr pbVal;

        /// SHORT*
        [FieldOffset(0)]
        public IntPtr piVal;

        /// LONG*
        [FieldOffset(0)]
        public IntPtr plVal;

        /// LONGLONG*
        [FieldOffset(0)]
        public IntPtr pllVal;

        /// FLOAT*
        [FieldOffset(0)]
        public IntPtr pfltVal;

        /// DOUBLE*
        [FieldOffset(0)]
        public IntPtr pdblVal;

        /// VARIANT_BOOL*
        [FieldOffset(0)]
        public IntPtr pboolVal;

        /// SCODE*
        [FieldOffset(0)]
        public IntPtr pscode;

        /// CY*
        [FieldOffset(0)]
        public IntPtr pcyVal;

        /// DATE*
        [FieldOffset(0)]
        public IntPtr pdate;

        /// BSTR*
        [FieldOffset(0)]
        public IntPtr pbstrVal;

        /// IUnknown**
        [FieldOffset(0)]
        public IntPtr ppunkVal;

        /// IDispatch**
        [FieldOffset(0)]
        public IntPtr ppdispVal;

        /// SAFEARRAY**
        [FieldOffset(0)]
        public IntPtr pparray;

        /// VARIANT*
        [FieldOffset(0)]
        public IntPtr pvarVal;

        /// PVOID->void*
        [FieldOffset(0)]
        public IntPtr byref;

        /// CHAR->char
        [FieldOffset(0)]
        public byte cVal;

        /// USHORT->unsigned short
        [FieldOffset(0)]
        public ushort uiVal;

        /// ULONG->unsigned int
        [FieldOffset(0)]
        public uint ulVal;

        /// ULONGLONG->unsigned __int64
        [FieldOffset(0)]
        public ulong ullVal;

        /// INT->int
        [FieldOffset(0)]
        public int intVal;

        /// UINT->unsigned int
        [FieldOffset(0)]
        public uint uintVal;

        /// DECIMAL*
        [FieldOffset(0)]
        public IntPtr pdecVal;

        /// CHAR*
        [FieldOffset(0)]
        public IntPtr pcVal;

        /// USHORT*
        [FieldOffset(0)]
        public IntPtr puiVal;

        /// ULONG*
        [FieldOffset(0)]
        public IntPtr pulVal;

        /// ULONGLONG*
        [FieldOffset(0)]
        public IntPtr pullVal;

        /// INT*
        [FieldOffset(0)]
        public IntPtr pintVal;

        /// UINT*
        [FieldOffset(0)]
        public IntPtr puintVal;

        /// ___tagBRECORD
        [FieldOffset(0)]
        public brecVal Struct1;
    }
}