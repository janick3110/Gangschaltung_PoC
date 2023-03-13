using System.Windows.Forms;

namespace Gangschaltung_PoC
{
    internal class GUIController
    {
        private Label currentGear;
        private NumericUpDown speed;
        private NumericUpDown rpm;

        private delegate void UpdateGearLabel(string data);
        private delegate void DelegateUpdateSpeedTextBox(string value);
        private delegate void DelegateUpdateRPMTextBox(string value);

        public GUIController(Label currentGear, NumericUpDown speed, NumericUpDown rpm)
        {
            this.currentGear = currentGear;
            this.speed = speed;
            this.rpm = rpm;
        }






        #region Update Gear Label
        public void Update(string data)
        {
            currentGear.Invoke(new UpdateGearLabel(UpdateGear),data);
        }

        private void UpdateGear(string data)
        {
            currentGear.Text = data;
        }
        #endregion

        #region Update Speed Text Box
        public void UpdateSpeedTextBox(string data)
        {
            currentGear.Invoke(new DelegateUpdateSpeedTextBox(UpdateSpeed), data);
        }

        private void UpdateSpeed(string data)
        {
            speed.Text = data;
        }
        #endregion

        #region Update RPM Text Box
        public void UpdateRPMTextBox(string data)
        {
            currentGear.Invoke(new DelegateUpdateRPMTextBox(UpdateRPM), data);
        }

        private void UpdateRPM(string data)
        {
            rpm.Text = data;
        }
        #endregion

    }
}