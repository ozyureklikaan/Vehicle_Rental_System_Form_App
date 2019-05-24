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

namespace VehicleRentalSystem.views.User
{
    public partial class RentingPage : Form
    {
        private Persons _usernameSession;
        private List<Vehicles> vehiclesToRent = new List<Vehicles>();
        public RentingPage(Persons _usernameSession)
        {
            InitializeComponent();
            this._usernameSession = _usernameSession;
        }

        private void RentingPage_Load(object sender, EventArgs e)
        {
            ListVehicles();
        }

        private async void BtnRent_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    RentalTransactions rentalTransaction = new RentalTransactions()
                    {
                        PersonID = _usernameSession.PersonID,
                        VehicleID = (int)dataGVRentingVehicle.CurrentRow.Cells["VehicleID"].Value
                    };

                    Vehicles vehicle = new Vehicles()
                    {
                        VehicleID = (int)dataGVRentingVehicle.CurrentRow.Cells["VehicleID"].Value,
                        CompanyID = (int)dataGVRentingVehicle.CurrentRow.Cells["CompanyID"].Value,
                        VehicleBrand = (string)dataGVRentingVehicle.CurrentRow.Cells["VehicleBrand"].Value,
                        VehicleModel = (string)dataGVRentingVehicle.CurrentRow.Cells["VehicleModel"].Value,
                        RequiredAgeOfDrivingLicense = (int)dataGVRentingVehicle.CurrentRow.Cells["RequiredAgeOfDrivingLicense"].Value,
                        MinimumAgeLimit = (int)dataGVRentingVehicle.CurrentRow.Cells["MinimumAgeLimit"].Value,
                        DailyKilometerLimit = (int)dataGVRentingVehicle.CurrentRow.Cells["DailyKilometerLimit"].Value,
                        InstantKilometerOfTheVehicle = (int)dataGVRentingVehicle.CurrentRow.Cells["InstantKilometerOfTheVehicle"].Value,
                        Airbag = (bool)dataGVRentingVehicle.CurrentRow.Cells["Airbag"].Value,
                        BaggageVolume = (int)dataGVRentingVehicle.CurrentRow.Cells["BaggageVolume"].Value,
                        NumberOfSeats = (int)dataGVRentingVehicle.CurrentRow.Cells["NumberOfSeats"].Value,
                        DailyRentPrice = (decimal)dataGVRentingVehicle.CurrentRow.Cells["DailyRentPrice"].Value,
                        LeasingStatus = true
                    };

                    rentalTransaction.Vehicles.Add(vehicle);

                    UpdateVehicle(vehicle);

                    var serializedProduct = JsonConvert.SerializeObject(rentalTransaction);
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("api/RentalTransaction", content);
                    if (result.IsSuccessStatusCode)
                    {
                        success = true;
                    }

                    if (success)
                    {
                        MessageBox.Show("Renting successful.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong. Please try again.");
                    }
                    ListVehicles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened : " + ex.Message);
            }
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

                    using (var result = await client.GetAsync("api/Vehicle"))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            var value = result.Content.ReadAsStringAsync().Result;
                            var data = JsonConvert.DeserializeObject<ResponseContent<Vehicles>>(value).Data.ToList();

                            foreach (Vehicles dataVehicle in data)
                            {
                                if (!dataVehicle.LeasingStatus)
                                {
                                    vehiclesToRent.Add(dataVehicle);
                                }
                            }
                            dataGVRentingVehicle.DataSource = vehiclesToRent;
                            if (dataGVRentingVehicle.DataSource == null)
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

        private async void UpdateVehicle(Vehicles vehicle)
        {
            try
            {
                bool success = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var serializedProduct = JsonConvert.SerializeObject(vehicle);
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    var result = await client.PutAsync("api/Vehicle/" + vehicle.VehicleID, content);
                    if (result.IsSuccessStatusCode)
                    {
                        success = true;
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
