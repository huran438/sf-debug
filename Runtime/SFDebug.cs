namespace SFramework.Debug.Runtime
{
    public static class SFDebug
    {
        public static bool IsDebug { get; private set; }

        public static void SetDebug(bool isDebug)
        {
            IsDebug = isDebug;
        }
    }
}