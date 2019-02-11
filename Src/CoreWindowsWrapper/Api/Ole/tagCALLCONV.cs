namespace CoreWindowsWrapper.Api.Ole
{
    public enum tagCALLCONV
    {
        /// CC_FASTCALL -> 0
        CC_FASTCALL = 0,

        /// CC_CDECL -> 1
        CC_CDECL = 1,

        /// CC_MSCPASCAL -> CC_CDECL+1
        CC_MSCPASCAL = (CC_CDECL + 1),

        /// CC_PASCAL -> CC_MSCPASCAL
        CC_PASCAL = CC_MSCPASCAL,

        /// CC_MACPASCAL -> CC_PASCAL+1
        CC_MACPASCAL = (CC_PASCAL + 1),

        /// CC_STDCALL -> CC_MACPASCAL+1
        CC_STDCALL = (CC_MACPASCAL + 1),

        /// CC_FPFASTCALL -> CC_STDCALL+1
        CC_FPFASTCALL = (CC_STDCALL + 1),

        /// CC_SYSCALL -> CC_FPFASTCALL+1
        CC_SYSCALL = (CC_FPFASTCALL + 1),

        /// CC_MPWCDECL -> CC_SYSCALL+1
        CC_MPWCDECL = (CC_SYSCALL + 1),

        /// CC_MPWPASCAL -> CC_MPWCDECL+1
        CC_MPWPASCAL = (CC_MPWCDECL + 1),

        /// CC_MAX -> CC_MPWPASCAL+1
        CC_MAX = (CC_MPWPASCAL + 1),
    }
}