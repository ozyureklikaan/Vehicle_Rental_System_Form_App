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
using System.Net.Http;
using System.Net.Http.Headers;
using VehicleRentalSystem.Models.Concretes;
using Newtonsoft.Json;
using VehicleRentalSystemFormApp.RestApi.views;

namespace VehicleRentalSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            //ResetAllSession();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        /*private void ResetAllSession()
        {
            _usernameSession = DefaultValueForSession;
            _companyNameSession = DefaultValueForSession;
        }*/

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void BtnUserLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                Persons loginAccount = new Persons();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    Persons persons = new Persons()
                    {
                        Username = txtULIUsername.Text,
                        Password = txtULIPassword.Text
                    };

                    using (var result = await client.GetAsync("api/Person"))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            var value = result.Content.ReadAsStringAsync().Result;
                            var data = JsonConvert.DeserializeObject<ResponseContent<Persons>>(value).Data.ToList();

                            foreach (Persons dataPerson in data)
                            {
                                if (dataPerson.Username.Equals(persons.Username) && dataPerson.Password.Equals(persons.Password))
                                {
                                    loginAccount = dataPerson;
                                    break;
                                }
                            }
                            if (loginAccount.PersonID != 0)
                            {
                                UserHomePage userHomePage = new UserHomePage(loginAccount);
                                userHomePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("User not found. Please check username and password");
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

        private void BtnSignUpUser_Click(object sender, EventArgs e)
        {
            UserSignUpPage userSignUpPage = new UserSignUpPage();
            userSignUpPage.Show();
            this.Hide();
        }

        private async void BtnCompanyLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                Companies loginAccount = new Companies();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:54300/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    Companies company = new Companies()
                    {
                        CompanyName = txtCLICompanyName.Text,
                        Password = txtCLIPassword.Text
                    };

                    using (var result = await client.GetAsync("api/Company"))
                    {
                        if (result.IsSuccessStatusCode)
                        {
                            var value = result.Content.ReadAsStringAsync().Result;
                            var data = JsonConvert.DeserializeObject<ResponseContent<Companies>>(value).Data.ToList();


                            foreach (Companies dataCompany in data)
                            {
                                if (dataCompany.CompanyName.Equals(company.CompanyName) && dataCompany.Password.Equals(company.Password))
                                {
                                    loginAccount = dataCompany;
                                    break;
                                }
                            }
                            if (loginAccount.CompanyID != 0)
                            {
                                CompanyHomePage companyHomePage = new CompanyHomePage(loginAccount);
                                companyHomePage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Company not found. Please check username and password");
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

        private void BtnSignUpCompany_Click(object sender, EventArgs e)
        {
            CompanySignUpPage companySignUpPage = new CompanySignUpPage();
            companySignUpPage.Show();
            this.Hide();
        }
    }
}
