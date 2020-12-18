using Employee_Manager.Classes;
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

namespace Employee_Manager.Forms
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private async void btnSubmit_ClickAsync(object sender, EventArgs e)
         {
            User userdata = new User()
            {
                name = txtName.Text,
                gender = txtGender.Text,
                status = comboStatus.SelectedItem.ToString(),
                email = txtEmail.Text,
                created_at = dateCreated.Value.ToString(),
                updated_at = dateUpdated.Value.ToString()
            };

            await AddRecord(userdata);

        }
        private async Task AddRecord(User userData)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                try
                {
                    var json = JsonConvert.SerializeObject(userData, Formatting.Indented);

                    var stringContent = new StringContent(json);

                    HttpResponseMessage response = await httpClient.PostAsync("users", stringContent);  //.PostAsync("users");

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        var strResult = JsonConvert.DeserializeObject<UsersData>(result.Replace(" ", ""));

                        var res = JsonConvert.DeserializeObject(result);

                        //return result;
                    }
                    else
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void btnCreatedNow_Click(object sender, EventArgs e)
        {
            dateCreated.Value = DateTime.Now;
        }

        private void btnUpdatedNow_Click(object sender, EventArgs e)
        {
            dateUpdated.Value = DateTime.Now;
        }
    }
}
