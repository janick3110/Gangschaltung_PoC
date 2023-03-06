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
        private Car car;

        public GUI()
        {
            InitializeComponent();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if (car == null || car.EngineON == false)
            {
                int.TryParse(tbGears.Text, out int gearCount);
                int.TryParse(tbHP.Text, out int horsepower);
                int.TryParse(tbWeight.Text, out int weight);

                car = new Car(weight, gearCount, horsepower);
                car.EngineON = true;

                btnSwitch.BackColor = Color.LawnGreen;
                lblCurrentGear.Text = car.Gearbox.CurrentGear.ToString();
            }
            else
            {
                car.EngineON = false;
                btnSwitch.BackColor = Color.Tomato;
                lblCurrentGear.Text = "-";
            }


            


        }
    }
}
