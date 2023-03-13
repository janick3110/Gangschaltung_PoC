using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gangschaltung_PoC
{
    internal class Physics
    {
        private double g;

        public Physics(double g = 9.81)
        {
            this.g = g;
        }

        public double CalculateForces(double velocity, double weight)
        {
            double forces = 0;
            forces += CalculateAirResistance(velocity);
            forces += CalculateRollingResistance(weight);

            return forces;
        }





        private double CalculateAirResistance(double velocity)
        {
            double c = 0.3; // Luftwiderstandskoeffizient
            double A = 2.0; //Frontfläche in Quadratmetern
            double rho = 1.2; // Luftdichte in kg/m^3

            return 0.5 * c * A * rho * velocity * velocity;
        }

        private double CalculateRollingResistance(double weight)
        {
            double crr = 0.01; // Beispielwert für den Rollwiderstandskoeffizienten

            return crr * weight;
        }


    }
}
