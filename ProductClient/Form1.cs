using System;
using System.Collections.Generic;
using System.Net.Http;      // HttpClient
using System.Windows.Forms;
using ProductsAPI.Models;   // Product
using System.Text.Json;     // JsonSerializer; Alternate assembly:  Newtonsoft.Json;

namespace ProductClient
{
    public partial class Form1 : Form
    {
        public HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new HttpClient(); 
            client.BaseAddress = new Uri("http://localhost/");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }
        private async void btnGetAllProducts_Click(object sender, EventArgs e)
        {   
            HttpResponseMessage response = await client.GetAsync("api/products");
            var prodArray = response.Content.ReadAsStreamAsync().Result;
            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(prodArray);
            string productList = "";
            foreach (var product in products)
            {
                productList += product.prodName + ",  " + product.prodCategory + ",  " + product.prodPrice + "\n";

            }
            lblAllProducts.Text = productList;
        }
        private async void  btnGetProd_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response = await client.GetAsync("api/products/" + txtProdId.Text);
            var prod = response.Content.ReadAsStreamAsync().Result;
            var product = JsonSerializer.Deserialize<Product>(prod);
            lblProduct.Text = product.prodName + ",  " + product.prodCategory + ",  " + product.prodPrice + "\n";
        }
    }
}
