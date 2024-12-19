using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountFinder.Settings
{
    internal static class Settings
    {
        public static readonly CVar<WorkModes> WorkMode = new(nameof(WorkMode), WorkModes.WriteAndCalculate, true);
    }

    public enum WorkModes
    { 
        WriteAndCalculate,
        RealtimeCalculate
    }
}
