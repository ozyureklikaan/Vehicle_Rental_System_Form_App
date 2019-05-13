using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleRentalSystem
{
    public partial class UserSignUpPage : Form
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private void UserSignUpPage_Load(object sender, EventArgs e)
        {
            //txtUSUName.Text;
            //txtUSULastName.Text;
            //txtUSUUsername.Text;
            //txtUSUPassword.Text;
            //txtUSUAge.Text;
        }

        private void UserSignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void BtnUserSignUp_Click(object sender, EventArgs e)
        {
            //User Information Checking.

            //IF: Informations is appropriate, Company Adding to DB and redirect to HomePage for Log-In
            if (true)
            {
                MessageBox.Show("Registration is successful.");

                this.Close();
            } //IF: Information is not appropriate, Show "try again" message.
            else
            {
                MessageBox.Show("This information is not appropriate. Please check and try again.");
            }
        }
    }
}
