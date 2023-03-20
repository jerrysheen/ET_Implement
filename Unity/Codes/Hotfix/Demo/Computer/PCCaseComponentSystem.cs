using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class PCCaseComponentSystem
    { 
        public static void StartPower(this PCCaseComponent self) 
        {
            Log.Debug("Power started");
        }
    }
}
