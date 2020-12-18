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
    public partial class Search : Form
    {
        public Search()
        {
            //pnlResult.Hide();
            InitializeComponent();
            hideSearchResults();
        }

        private void hideSearchResults()
        {
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            lblName.Hide();
            lblEmail.Hide();
            lblGender.Hide();
            lblStatus.Hide();
            lblCreatedAt.Hide();
            lblUpdatedAt.Hide();
            pnlResult.Hide();
            btnClear.Hide();

        }
        private void showSearchResults()
        {
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            lblName.Show();
            lblEmail.Show();
            lblGender.Show();
            lblStatus.Show();
            lblCreatedAt.Show();
            lblUpdatedAt.Show();
            pnlResult.Show();
            btnClear.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (numUserID.Value > 0)
            {

                var userId = int.Parse(numUserID.Value.ToString());

                var result = await GetUserDetailsAsync(userId);

                if (result.data.id > 0)
                {

                    lblName.Text = result.data.name;
                    lblGender.Text = result.data.gender;
                    lblStatus.Text = result.data.status;
                    lblCreatedAt.Text = result.data.created_at.ToString();
                    lblUpdatedAt.Text = result.data.updated_at.ToString();
                    lblEmail.Text = result.data.email;

                    showSearchResults();
                }
                else
                {
                    MessageBox.Show("No results found. Please enter a new id");
                    hideSearchResults();
                }
            }
            else if (!string.IsNullOrEmpty(txtName.Text))
            {
                var name = txtName.Text;
                var result = await GetUserDetailsAsync(name);
            }
            else
            {
                MessageBox.Show("Please enter one of the above");
            }
        }

        private async Task<UserSearchData> GetUserDetailsAsync(int userid)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("users/" + userid);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var strResult = JsonConvert.DeserializeObject<UserSearchData>(result);
                        return strResult;
                    }
                    else
                    {
                        var result = response.Content.ReadAsStringAsync().Result;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, please retry");
                }

            }

            return null;
        }
        private async Task<UsersData> GetUserDetailsAsync(string firstname)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("users?first_name=" + firstname);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        var strResult = JsonConvert.DeserializeObject<UsersData>(result);

                        return strResult;
                    }
                    else
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show("Error, please retry");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, please retry");
                }

            }

            return null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            hideSearchResults();
        }

    }
}
