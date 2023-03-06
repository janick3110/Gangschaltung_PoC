using System;
using System.Collections.Generic;
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
            while (true)
            {
                if (Keyboard.IsKeyDown(shift) && Keyboard.IsKeyDown(Key.D) && !hasshifted)
                {
                    car.Gearbox.ShiftGear(+1);
                    guiController.Update(car.Gearbox.CurrentGear.ToString());
                    hasshifted = true;
                } else if (Keyboard.IsKeyDown(shift) && Keyboard.IsKeyDown(Key.A) && !hasshifted)
                {
                    car.Gearbox.ShiftGear(-1);
                    guiController.Update(car.Gearbox.CurrentGear.ToString());
                    hasshifted = true;
                }

                if (Keyboard.IsKeyUp(shift))
                {
                    hasshifted = false;
                }
            }
        }


    }
}
