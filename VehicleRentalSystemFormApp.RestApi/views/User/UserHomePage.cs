using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalSystem.Models.Concretes;
using VehicleRentalSystemFormApp.RestApi.views.User;

namespace VehicleRentalSystem.views.User
{
    public partial class UserHomePage : Form
    {
        private Persons _usernameSession { get; set; }

        public UserHomePage(Persons _usernameSession)
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
            RentingPage rentingPage = new RentingPage(_usernameSession);
            rentingPage.Show();
        }

        private void BtnListMyVehicles_Click(object sender, EventArgs e)
        {
            ListUserVehiclesPage listUserVehiclesPage = new ListUserVehiclesPage(_usernameSession);
            listUserVehiclesPage.Show();
        }
    }
}
