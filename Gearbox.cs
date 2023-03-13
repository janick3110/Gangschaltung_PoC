using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gangschaltung_PoC
{
    internal class Gearbox
    {
        private int currentGear;
        private int gearCount;
        private int[] ratios = { 3800, 2250, 1500, 1100, 850 };

        public Gearbox(int gearCount) { 
            this.gearCount = gearCount;
            currentGear = 1;
        }

        public int CurrentGear { get => currentGear;}

        public void ShiftGear (int direction)
        {
            currentGear += direction;

            if (gearCount < currentGear)
            {
                currentGear = gearCount;
            }
            if (currentGear <= 0)
            {
                currentGear = 1;
            }
        }

        public int GetCurrentRatio()
        {
            return ratios[currentGear];
        }



    }
}
