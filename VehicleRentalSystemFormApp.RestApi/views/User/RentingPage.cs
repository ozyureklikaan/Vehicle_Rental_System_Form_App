using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalSystem.views.User
{
    public partial class RentingPage : Form
    {
        public RentingPage()
        {
            InitializeComponent();
        }

        private void RentingPage_Load(object sender, EventArgs e)
        {

        }

        private void BtnRent_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Renting successful.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong. Please try again.");
            }
        }
    }
}
