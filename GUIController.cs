using System.Windows.Forms;

namespace Gangschaltung_PoC
{
    internal class GUIController
    {
        private Label currentGear;
        private delegate void UpdateGearLabel(string data);


        public GUIController(Label currentGear)
        {
            this.currentGear = currentGear;
        }

        public void Update(string data)
        {
            currentGear.Invoke(new UpdateGearLabel(UpdateGear),data);
        }

        private void UpdateGear(string data)
        {
            currentGear.Text = data;
        }


    }
}