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
       
        private Gearbox gearbox;
        private Engine engine;
        private Physics physics;

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
            engine = new Engine(horsepower);
            gearbox = new Gearbox(gears);
            physics = new Physics();
        }

        public bool EngineON { get => engineON; set => engineON = value; }
        public Gearbox Gearbox { get => gearbox;}
        public double Acceleration { get => acceleration; set => acceleration = value; }

        public int MaxRPM => maxRPM;

 

        // Getter-Methoden
        public double GetSpeed()
        {
            return speed;
        }

        public double GetAcceleration(int degree)
        {
            double resistingForces = physics.CalculateForces(speed, weight);
            double forces = (engine.CalculateDrivingForce(gearbox.CurrentGear, axleRatio, wheelRadius * 2) - resistingForces);
            acceleration = forces / weight;
            return acceleration;
        }


        public void Accelerate(double time)
        {
            speed += GetAcceleration(0) * time * 500; 
        }












    }
}

