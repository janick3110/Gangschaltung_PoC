using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Gangschaltung_PoC
{
    internal class Car
    {
        //Car Stats
        private int weight;
       


        private double wheelRadius = 0.3;
        private double axleRatio = 3.94;

        //Driving Stats
        private double rpm;
        private double speed;
        private double acceleration;
        private bool engineON;
        
        private readonly int maxRPM = 7000;
        private double position = 0;

        public Car(int weight, int gears, int horsepower)
        {
            this.weight = weight;

        }

        public bool EngineON { get => engineON; set => engineON = value; }

        public double Acceleration { get => acceleration; set => acceleration = value; }

        public int MaxRPM => maxRPM;

 

        // Getter-Methoden
        public double GetSpeed()
        {
            return speed;
        }
















    }
}

