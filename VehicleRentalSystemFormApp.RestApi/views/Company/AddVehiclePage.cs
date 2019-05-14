using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalSystem.views.Company
{
    public partial class AddVehiclePage : Form
    {
        public AddVehiclePage()
        {
            InitializeComponent();
        }

        private void AddVehiclePage_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            //Information Checking

            //IF: Information is appropriate, Vehicle add to DB.
            if(true)
            {
                MessageBox.Show("Adding successful.");
                this.Close();
            }
            else
            {
                MessageBox.Show("This information is not appropriate. Please check and try again.");
            }
        }
    }
}
