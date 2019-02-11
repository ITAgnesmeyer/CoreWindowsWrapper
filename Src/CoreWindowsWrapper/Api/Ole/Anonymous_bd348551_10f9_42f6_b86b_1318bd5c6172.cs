using System;
using System.Runtime.InteropServices;

namespace CoreWindowsWrapper.Api.Ole
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Anonymous_bd348551_10f9_42f6_b86b_1318bd5c6172
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

        /// wireBSTR->FLAGGED_WORD_BLOB*
        [FieldOffset(0)]
        public IntPtr bstrVal;

        /// IUnknown*
        [FieldOffset(0)]
        public IntPtr punkVal;

        /// IDispatch*
        [FieldOffset(0)]
        public IntPtr pdispVal;

        /// wirePSAFEARRAY->wireSAFEARRAY*
        [FieldOffset(0)]
        public IntPtr parray;

        /// wireBRECORD->_wireBRECORD*
        [FieldOffset(0)]
        public IntPtr brecVal;

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

        /// wireBSTR*
        [FieldOffset(0)]
        public IntPtr pbstrVal;

        /// IUnknown**
        [FieldOffset(0)]
        public IntPtr ppunkVal;

        /// IDispatch**
        [FieldOffset(0)]
        public IntPtr ppdispVal;

        /// wirePSAFEARRAY*
        [FieldOffset(0)]
        public IntPtr pparray;

        /// wireVARIANT*
        [FieldOffset(0)]
        public IntPtr pvarVal;

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

        /// DECIMAL->tagDEC
        [FieldOffset(0)]
        public tagDEC decVal;

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
    }
}