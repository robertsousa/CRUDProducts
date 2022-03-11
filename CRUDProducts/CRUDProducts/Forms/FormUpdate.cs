using CRUDProducts.Model;
using CRUDProducts.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDProducts.Forms
{
    public partial class FormUpdate : Form
    {
        Product productToUpdate;

        public FormUpdate(Product product)
        {
            productToUpdate = product;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            txbCode.Text = productToUpdate.Code;
            txbDecription.Text = productToUpdate.Description;
            txbPrice.Text = productToUpdate.Price.ToString();
            txbQuantity.Text = productToUpdate.Quantity.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = productToUpdate.Id,
                Code = txbCode.Text,
                Description = txbDecription.Text,
                Price = Convert.ToDecimal(txbPrice.Text),
                Quantity = Convert.ToInt32(txbQuantity.Text),
            };
            ProductRepository repository = new ProductRepository();
            repository.UpdateProduct(product);
            Close();
        }
    }
}
