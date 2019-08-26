using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianRoulletteGame
{
    public class ClassForLoopSystem//This is another class
    {
        public int Loading { get; set; }//Load variable
        public int Spinning { get; set; }//Spin Variable 

        public int LoopShot(int skippingShoot)//This method for shoting time
        {
            if (skippingShoot == 6)
            {
                skippingShoot = 1;
            }
            else
            {
                skippingShoot++;
            }
            return skippingShoot;
        }
    }
}
