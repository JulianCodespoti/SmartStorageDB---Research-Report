using System.Windows.Forms;

namespace FurnitureInventorySystem
{
    public partial class SpeedForm : Form
    {
        public SpeedForm(int items, double speed)
        {
            InitializeComponent();
            SpeedTime.Text = "In " + speed + " seconds";
            NumberOfItems.Text = items + " items";
        }

        private void SpeedForm_Load(object sender, System.EventArgs e)
        {
        }

        private void SpeedText_Click(object sender, System.EventArgs e)
        {
        }
    }
}