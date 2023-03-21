using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ET
{
    public class ComputerSystemAwake : AwakeSystem<Computer>
    {
        public override void Awake(Computer self)
        {
            Log.Debug("Our Computer awake..");
        }
    }

    public class ComputerSystemUpdate : UpdateSystem<Computer>
    {
        public override void Update(Computer self)
        {
            Log.Debug("Our Computer update..");
        }
    }

    public class ComputerSystemDestroy : DestroySystem<Computer>
    {
        public override void Destroy(Computer self)
        {
            Log.Debug("this Object has been destroied");
        }
    }


    public static class ComputerSystem
    {
        public static void Start(this Computer self) 
        {
            Log.Debug("Init Computer system");

            self.GetComponent<PCCaseComponent>().StartPower();
        }
    }
}
