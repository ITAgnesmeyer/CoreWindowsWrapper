﻿namespace CoreWindowsWrapper.Api.Ole
{
    public enum tagINVOKEKIND
    {
        /// INVOKE_FUNC -> 1
        INVOKE_FUNC = 1,

        /// INVOKE_PROPERTYGET -> 2
        INVOKE_PROPERTYGET = 2,

        /// INVOKE_PROPERTYPUT -> 4
        INVOKE_PROPERTYPUT = 4,

        /// INVOKE_PROPERTYPUTREF -> 8
        INVOKE_PROPERTYPUTREF = 8,
    }
}