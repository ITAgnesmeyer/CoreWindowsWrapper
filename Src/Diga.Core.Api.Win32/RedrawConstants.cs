namespace Diga.Core.Api.Win32
{
    public static class RedrawConstants
    {
        
        /// SMTO_NORMAL -> 0x0000
        public const int SMTO_NORMAL = 0;
    
        /// SMTO_BLOCK -> 0x0001
        public const int SMTO_BLOCK = 1;
    
        /// SMTO_ABORTIFHUNG -> 0x0002
        public const int SMTO_ABORTIFHUNG = 2;
    
        /// RDW_INVALIDATE -> 1
        public const int RDW_INVALIDATE = 1;
    
        /// RDW_INTERNALPAINT -> 2
        public const int RDW_INTERNALPAINT = 2;
    
        /// RDW_ERASE -> 4
        public const int RDW_ERASE = 4;
    
        /// RDW_VALIDATE -> 8
        public const int RDW_VALIDATE = 8;
    
        /// RDW_NOINTERNALPAINT -> 16
        public const int RDW_NOINTERNALPAINT = 16;
    
        /// RDW_NOERASE -> 32
        public const int RDW_NOERASE = 32;
    
        /// RDW_NOCHILDREN -> 64
        public const int RDW_NOCHILDREN = 64;
    
        /// RDW_ALLCHILDREN -> 128
        public const int RDW_ALLCHILDREN = 128;
    
        /// RDW_UPDATENOW -> 256
        public const int RDW_UPDATENOW = 256;
    
        /// RDW_ERASENOW -> 512
        public const int RDW_ERASENOW = 512;
    
        /// RDW_FRAME -> 1024
        public const int RDW_FRAME = 1024;
    
        /// RDW_NOFRAME -> 2048
        public const int RDW_NOFRAME = 2048;

    }
}