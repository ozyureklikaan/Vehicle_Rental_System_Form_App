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
    public partial class UserHomePage : Form
    {
        private string _usernameSession { get; set; }

        public UserHomePage(string _usernameSession)
        {
            InitializeComponent();
            this._usernameSession = _usernameSession;
        }

        private void UserHomePage_Load(object sender, EventArgs e)
        {

        }

        private void UserHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRentAVehicle_Click(object sender, EventArgs e)
        {
            RentingPage rentingPage = new RentingPage();
            rentingPage.Show();
        }
    }
}
