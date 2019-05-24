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
    public partial class UserSignUpPage : Form
    {
        public UserSignUpPage()
        {
            InitializeComponent();
        }

        private void UserSignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void UserSignUpPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private async void BtnUserSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = false;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                    Persons person = new Persons()
                    {
                        PersonName = txtUSUName.Text,
                        PersonLastName = txtUSULastName.Text,
                        Age = int.Parse(txtUSUAge.Text),
                        Username = txtUSUUsername.Text,
                        Password = txtUSUPassword.Text
                    };

                    var serializedProduct = JsonConvert.SerializeObject(person);
                    var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync("api/Person", content);
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
