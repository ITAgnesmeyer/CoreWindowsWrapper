namespace CoreWindowsWrapper
{
    /// <summary>
    /// Represents possible values returned by the MessageBox function.
    /// </summary>
    public enum MessageBoxResult : uint
    {
        Ok = 1,
        Cancel=2,
        Abort=3,
        Retry=4,
        Ignore=5,
        Yes=6,
        No=7,
        Close=8,
        Help=9,
        TryAgain=10,
        Continue=11,
        Timeout = 32000
    }
}