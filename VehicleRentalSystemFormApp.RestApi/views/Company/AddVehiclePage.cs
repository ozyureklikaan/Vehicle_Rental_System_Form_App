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

namespace VehicleRentalSystem.views.Company
{
    public partial class AddVehiclePage : Form
    {
        private Companies __companySession;
        public AddVehiclePage(Companies __companySession)
        {
            InitializeComponent();
            this.__companySession = __companySession;
        }

        private void AddVehiclePage_Load(object sender, EventArgs e)
        {
            comboCompanyName.Items.Add(__companySession.CompanyName);
        }

        private async void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                    Vehicles vehicle = new Vehicles()
                    {
                        CompanyID = __companySession.CompanyID,
                        VehicleBrand = txtVehicleBrand.Text,
                        VehicleModel = txtVehicleModel.Text,
                        RequiredAgeOfDrivingLicense = int.Parse(txtDrivingLicense.Text),
                        MinimumAgeLimit = int.Parse(txtMinAgeLimit.Text),
                        DailyKilometerLimit = int.Parse(txtDailyKilometerLimit.Text),
                        InstantKilometerOfTheVehicle = int.Parse(txtInstantKilometer.Text),
                        Airbag = (comboAirBag.Text.Equals("Available")) ? true : false,
                        BaggageVolume = int.Parse(txtBaggageVolume.Text),
                        NumberOfSeats = int.Parse(txtNumberOfSeats.Text),
                        DailyRentPrice = decimal.Parse(txtDailyRentPrice.Text),
                        LeasingStatus = false
                    };

                    var serializedProduct = JsonConvert.SerializeObject(vehicle);
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("api/Vehicle", content);
                    if (result.IsSuccessStatusCode)
                    {
                        success = true;
                    }

                    if (success)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error happend : ex" + ex.Message);
            }
        }
    }
}
