using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class frmAdd : Form
    {
        public string? Name;
        Location l;
        public frmAdd()
        {
            InitializeComponent();
            Name = "";
        }
        public frmAdd(string name)
        {
            InitializeComponent();
            Name = name;
            FillForm();
        }
        public void FillForm()
        {
            try
            {
                var client = new RestClient("https://localhost:44369/");
                var request = new RestRequest("Api/GetLocations/" + Name, Method.GET);
                var queryResult = client.Execute<List<Location>>(request);
                l = new Location();
                l = new JsonDeserializer().Deserialize<Location>(queryResult);
                txtbox_name.Text = l.Name;
                numUD_lat.Value = Convert.ToDecimal(l.Latitude);
                numUD_lon.Value = Convert.ToDecimal(l.Longtitude);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Name == "")
                {
                    l = new Location();
                    var client = new RestClient("https://localhost:44369/");
                    var request = new RestRequest("Api/GetLocations/", Method.POST);
                    request.RequestFormat = DataFormat.Json;
                    request.AddJsonBody(new Location
                    {
                        Name = txtbox_name.Text,
                        Longtitude = Convert.ToDouble(numUD_lon.Value),
                        Latitude = Convert.ToDouble(numUD_lat.Value)
                    });
                    client.Execute(request);
                    
                }

                else
                {
                    var client = new RestClient("https://localhost:44369/");
                    var request = new RestRequest("Api/GetLocations/" + Name, Method.PUT);
                    request.AddJsonBody(new Location
                    {
                        Name = txtbox_name.Text,
                        Longtitude = Convert.ToDouble(numUD_lon.Value),
                        Latitude = Convert.ToDouble(numUD_lat.Value)
                    });
                    client.Execute(request);
                    
                }

                this.Close();
                MessageBox.Show("Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
