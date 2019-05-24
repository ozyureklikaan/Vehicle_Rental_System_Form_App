using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRentalSystem.Models.Concretes;
using VehicleRentalSystemFormApp.RestApi.views;

namespace VehicleRentalSystem.views.Company
{
    public partial class CompanysVehiclesPage : Form
    {
        private Companies _companySession;
        public CompanysVehiclesPage(Companies _companySession)
        {
            InitializeComponent();
            this._companySession = _companySession;
        }

        private void CompanysVehiclesPage_Load(object sender, EventArgs e)
        {
            ListVehicles();
        }

        private void BtnListCompanysVehicle_Click(object sender, EventArgs e)
        {
            ListVehicles();
        }

        private async void ListVehicles()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var result = await client.GetAsync("api/Company/" + _companySession.CompanyID))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            var value = result.Content.ReadAsStringAsync().Result;
                            var data = JsonConvert.DeserializeObject<ResponseContent<Companies>>(value).Data.ToList();

                            foreach (Companies dataCompany in data)
                            {
                                dataGVCompanysVehicles.DataSource = dataCompany.Vehicles;
                            }
                            if (dataGVCompanysVehicles.DataSource == null)
                            {
                                MessageBox.Show("Vehicles not found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened : " + ex.Message);
            }
        }
    }
}
