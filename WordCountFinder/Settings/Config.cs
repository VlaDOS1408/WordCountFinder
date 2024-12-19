namespace WordCountFinder.Settings
{
    internal static class Config
    {
        public static readonly CVar<CalculateMode> WorkMode = new(nameof(WorkMode), CalculateMode.WriteAndCalculate, true);
    }

    public enum CalculateMode
    { 
        WriteAndCalculate,
        Realtime
    }
}
