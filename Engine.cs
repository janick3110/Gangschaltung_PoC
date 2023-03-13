using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gangschaltung_PoC
{
    internal class Engine
    {
        private int horsepower;
        private double[] gearRatioArray = { 2.5, 1.8, 1.2, 0.8, 0.5 };

        public Engine(int horsepower)
        {
            this.horsepower = horsepower;
        }

        public double[] GearRatioArray { get => gearRatioArray; set => gearRatioArray = value; }
        public int Horsepower { get => horsepower; set => horsepower = value; }

        public double CalculateDrivingForce(int currentGear, double axleRatio, double wheelDiameter)
        {
            double drivingForce = horsepower * 0.7355 * gearRatioArray[currentGear - 1] * axleRatio / 0.5 * wheelDiameter;
            return drivingForce;
        }


    }
}
