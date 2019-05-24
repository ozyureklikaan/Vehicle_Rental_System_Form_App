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

namespace VehicleRentalSystem
{
    public partial class CompanySignUpPage : Form
    {
        public CompanySignUpPage()
        {
            InitializeComponent();
        }

        private void CompanySignUpPage_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void CompanySignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private async void BtnCompanySignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                    Companies company = new Companies()
                    {
                        CompanyName = txtCSUCompanyName.Text,
                        Password = txtCSUPassword.Text,
                        City = txtCSUCity.Text,
                        Address = txtCSUAddress.Text,
                        VehicleNumber = int.Parse(txtCSUVehicleNumber.Text),
                        CompanyScore = int.Parse(txtCSUScore.Text)
                    };

                    var serializedProduct = JsonConvert.SerializeObject(company);
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("api/Company", content);
                    if (result.IsSuccessStatusCode)
                    {
                        success = true;
                    }

                    if (success)
                    {
                        MessageBox.Show("Registration is successful.");

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
