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

namespace VehicleRentalSystemFormApp.RestApi.views.User
{
    public partial class ListUserVehiclesPage : Form
    {
        private Persons _usernameSession;
        private List<Vehicles> myVehicles = new List<Vehicles>();
        public ListUserVehiclesPage(Persons _usernameSession)
        {
            InitializeComponent();
            this._usernameSession = _usernameSession;
        }

        private void ListUserVehicles_Load(object sender, EventArgs e)
        {
            ListVehicles();
        }

        private void BtnRefreshList_Click(object sender, EventArgs e)
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

                    using (var result = await client.GetAsync("api/RentalTransaction"))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            var value = result.Content.ReadAsStringAsync().Result;
                            var data = JsonConvert.DeserializeObject<ResponseContent<RentalTransactions>>(value).Data.ToList();

                            foreach (RentalTransactions dataRentalTransactions in data)
                            {
                                if (dataRentalTransactions.PersonID == _usernameSession.PersonID)
                                {
                                    //
                                    using (var client2 = new HttpClient())
                                    {
                                        client2.BaseAddress = new Uri("http://localhost:54300/");
                                        client2.DefaultRequestHeaders.Accept.Clear();
                                        client2.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                                        using (var result2 = await client2.GetAsync("api/RentalTransaction/" + dataRentalTransactions.RentalID))
                                        {
                                            if (result2.IsSuccessStatusCode)
                                            {
                                                var value2 = result2.Content.ReadAsStringAsync().Result;
                                                var data2 = JsonConvert.DeserializeObject<ResponseContent<RentalTransactions>>(value2).Data.ToList();

                                                foreach (RentalTransactions dataRentalTransactions2 in data2)
                                                {
                                                    myVehicles.Add(dataRentalTransactions2.Vehicles.First());
                                                }
                                            }
                                        }
                                    }
                                    //
                                }
                            }

                            dataGVListUserVehicles.DataSource = myVehicles;

                            if (dataGVListUserVehicles.DataSource == null)
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
