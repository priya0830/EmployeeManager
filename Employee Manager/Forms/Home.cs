using Classes;
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

namespace Employee_Manager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

        }

        private async void btnViewAll_Click(object sender, EventArgs e)
        {
            // get details from API
            var result = await GetUserDetailsAsync();
            // parse into class
            UsersData UserDetails = JsonConvert.DeserializeObject<UsersData>(result);


            Forms.ViewDetails view = new Forms.ViewDetails(UserDetails);

            view.Show();

            // show them on screen

        }

        private async Task<string> GetUserDetailsAsync()
        {
            using(var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("users");

                    if(response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        var strResult = JsonConvert.DeserializeObject<UsersData>(result.Replace(" ", ""));
                        
                        var res = JsonConvert.DeserializeObject(result);

                        return result;
                    }
                    else
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                    }
                }
                catch(Exception ex)
                {

                }

            }

            return "";
        }
         

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            Forms.AddEmployee add = new Forms.AddEmployee();
            add.Show();
        }
        

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        
    }
}
