using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formMovie.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace formMovie
{
    public partial class ListMovies : UserControl
    {
        public ListMovies()
        {
            InitializeComponent();
        }
        public delegate void DelegateListAllClick(string btn);
        public event DelegateListAllClick listAll;
        private void ListMovies_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listAllMovies();
        }

        public void listAllMovies()
        {
            var t = Task.Run(() => GetURI(new Uri("https://localhost:5001/api/API")));
            t.Wait();
            JArray j = JArray.Parse(t.Result);
            DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(j.ToString(), (typeof(DataTable)));
            dataGridView1.DataSource = dataTable;
        }

        static async Task<string> GetURI(Uri u)
        {
            var response = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(u);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }
    }
}
