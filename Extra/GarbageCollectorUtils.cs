namespace FilterGenerator.Extra
{
    public static class GarbageCollectorUtils
    {
        public static void ActivateGarbageCollection()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}