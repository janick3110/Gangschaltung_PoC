using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Gangschaltung_PoC
{
    internal class CarController
    {
        private Key acceleration;
        private Key brake;
        private Key shift;
        private Car car;
        private Thread control;
        private GUIController guiController;


        public CarController(Car car, GUIController controller, Key acceleration = Key.W, Key brake = Key.S, Key shift = Key.LeftShift)
        {
            this.acceleration = acceleration;
            this.brake = brake;
            this.shift = shift;
            this.car = car;
            guiController = controller;
        }

        internal Car Car { get => car; set => car = value; }

        public void RunCar()
        {
            control = new Thread(CarControllingThread);
            control.SetApartmentState(ApartmentState.STA);
            control.Start();
        }

        public void StopCar()
        {
            control.Abort();
        }


        private void CarControllingThread()
        {
            bool hasshifted = false;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            while (true)
            {
                //Hochschalten
                if (Keyboard.IsKeyDown(shift) && Keyboard.IsKeyDown(Key.D) && !hasshifted)
                {
                    car.Gearbox.ShiftGear(+1);
                    guiController.Update(car.Gearbox.CurrentGear.ToString());
                    hasshifted = true;
                } 
                //Runterschalten
                else if (Keyboard.IsKeyDown(shift) && Keyboard.IsKeyDown(Key.A) && !hasshifted)
                {
                    car.Gearbox.ShiftGear(-1);
                    guiController.Update(car.Gearbox.CurrentGear.ToString());
                    hasshifted = true;
                }

                if (Keyboard.IsKeyUp(shift))
                {
                    hasshifted = false;
                }

                //Beschleunigen
                if (Keyboard.IsKeyDown(acceleration))
                {
                    car.Accelerate(stopwatch.Elapsed.TotalSeconds);
                    guiController.UpdateSpeedTextBox(car.GetSpeed().ToString());
                    
                }
                //Bremsen
                else if (Keyboard.IsKeyDown(brake))
                {
                    
                    guiController.UpdateSpeedTextBox(car.GetSpeed().ToString());
                }
                guiController.UpdateRPMTextBox(car.Acceleration.ToString());
                stopwatch.Restart();
                
            }
        }



    }
}
