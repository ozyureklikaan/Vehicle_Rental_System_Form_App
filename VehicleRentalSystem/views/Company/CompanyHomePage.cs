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
    public partial class CompanyHomePage : Form
    {
        private string _companySession { get; set; }

        public CompanyHomePage(string _companySession)
        {
            InitializeComponent();
            this._companySession = _companySession;
        }

        private void CompanyHomePage_Load(object sender, EventArgs e)
        {

        }

        private void CompanyHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehiclePage addVehiclePage = new AddVehiclePage();
            addVehiclePage.Show();
        }

        private void BtnListVehicles_Click(object sender, EventArgs e)
        {
            CompanysVehiclesPage companysVehiclesPage = new CompanysVehiclesPage();
            companysVehiclesPage.Show();
        }
    }
}
