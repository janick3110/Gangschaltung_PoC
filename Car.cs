using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gangschaltung_PoC
{
    internal class Car
    {
        //Car Stats
        private int weight;
        private int horsepower;
        private Gearbox gearbox;
        
        //Driving Stats
        private int rpm;
        private double speed;
        private bool engineON;


        public Car(int weight, int gears, int horsepower)
        {
            this.weight = weight;
            this.horsepower = horsepower;

            gearbox = new Gearbox(gears);
        }

        public bool EngineON { get => engineON; set => engineON = value; }
        public Gearbox Gearbox { get => gearbox;}
    }
}
