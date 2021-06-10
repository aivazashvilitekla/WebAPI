using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_getAll_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new RestClient("https://localhost:44369/");
                var request = new RestRequest("Api/GetLocations", Method.GET);
                var queryResult = client.Execute<List<Location>>(request).Data;
                dataGridView1.DataSource = queryResult;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_getByName_Click(object sender, EventArgs e)
        {
            try
            {
                string txt = textBox1.Text;
                var client = new RestClient("https://localhost:44369/");
                var request = new RestRequest("Api/GetLocations/" + txt, Method.GET);
                var queryResult = client.Execute<List<Location>>(request).Data;
                dataGridView1.DataSource = queryResult;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            f.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.CurrentRow;
                string name = (string)row.Cells["Name"].Value;

                DialogResult decision = MessageBox.Show("Are you sure?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (decision == DialogResult.Yes)
                {
                    var client = new RestClient("https://localhost:44369/");
                    var request = new RestRequest("Api/GetLocations/" + name, Method.DELETE);

                    client.Execute(request);
                }
                MessageBox.Show("Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            
            var row = dataGridView1.CurrentRow;
            string name = (string)row.Cells["Name"].Value;
            frmAdd f = new frmAdd(name);
            f.Show();
        }
    }
}
