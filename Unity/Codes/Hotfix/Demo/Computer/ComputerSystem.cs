using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ET
{
    public static class ComputerSystem
    {
        public static void Start(this Computer self) 
        {
            Log.Debug("Init Computer system");

            self.GetComponent<PCCaseComponent>().StartPower();
        }
    }
}
