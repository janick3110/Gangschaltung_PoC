using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gangschaltung_PoC
{
    public partial class GUI : Form
    {
        private CarController carController;
        private GUIController guiController;

        public GUI()
        {
            InitializeComponent();


            guiController = new GUIController(lblCurrentGear, nudSpeed, nudRPM);

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {


            if (carController == null || carController.Car == null || carController.Car.EngineON == false)
            {
                int.TryParse(tbGears.Text, out int gearCount);
                int.TryParse(tbHP.Text, out int horsepower);
                int.TryParse(tbWeight.Text, out int weight);

                var car = new Car(weight, gearCount, horsepower);
                car.EngineON = true;
                carController = new CarController(car, guiController);
                btnSwitch.BackColor = Color.LawnGreen;
                
                carController.RunCar();
            }
            else
            {
                carController.Car.EngineON = false;
                btnSwitch.BackColor = Color.Tomato;
                lblCurrentGear.Text = "-";
            }


            


        }
    }
}
