using CRUDProducts.Model;
using CRUDProducts.Repository;
using CRUDProducts.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            _ = LoadDataGridAsync();
            InitializeComponent();
        }

        public async Task LoadDataGridAsync()
        {
            ProductRepository repository = new ProductRepository();
            List<Product> allProduct = await repository.SelectAll();
            List<ProductView> productList = new List<ProductView>();

            foreach (Product item in allProduct)
            {
                ProductView product = new ProductView
                {
                    ID = item.Id,
                    Code = item.Code,
                    Description = item.Description,
                    Price = item.Price.ToString("C2"),
                    Quantity = item.Quantity.ToString()
                };
                productList.Add(product);
            }
            DgvProducts.Invoke((MethodInvoker)delegate
            {
                DgvProducts.DataSource = productList;
                DgvProducts.Refresh();
            });
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
