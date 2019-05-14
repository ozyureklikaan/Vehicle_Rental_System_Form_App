using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalSystem.views.User;
using VehicleRentalSystem.views.Company;

namespace VehicleRentalSystem
{
    public partial class HomePage : Form
    {
        private string _usernameSession { get; set; }
        private string _companyNameSession { get; set; }
        private const string DefaultValueForSession = "";

        public HomePage()
        {
            InitializeComponent();
            ResetAllSession();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            txtULIUsername.Text = _usernameSession;
            txtCLICompanyName.Text = _companyNameSession;
        }

        private void ResetAllSession()
        {
            _usernameSession = DefaultValueForSession;
            _companyNameSession = DefaultValueForSession;
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnUserLogIn_Click(object sender, EventArgs e)
        {
            string username = txtULIUsername.Text;
            string password = txtULIPassword.Text;
            //User Information Checking

            UserHomePage userHomePage = new UserHomePage(_usernameSession);
            userHomePage.Show();
            this.Hide();
        }

        private void BtnSignUpUser_Click(object sender, EventArgs e)
        {
            UserSignUpPage userSignUpPage = new UserSignUpPage();
            userSignUpPage.Show();
            this.Hide();
        }

        private void BtnCompanyLogIn_Click(object sender, EventArgs e)
        {
            string companyName = txtCLICompanyName.Text;
            string password = txtCLIPassword.Text;
            //Company Information Checking

            CompanyHomePage companyHomePage = new CompanyHomePage(_companyNameSession);
            companyHomePage.Show();
            this.Hide();
        }

        private void BtnSignUpCompany_Click(object sender, EventArgs e)
        {
            CompanySignUpPage companySignUpPage = new CompanySignUpPage();
            companySignUpPage.Show();
            this.Hide();
        }
    }
}
