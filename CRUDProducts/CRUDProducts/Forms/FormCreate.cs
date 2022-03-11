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
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txbCode.Text = string.Empty;
            txbDescription.Text = string.Empty; 
            txbPrice.Text = string.Empty;
            txbQuantity.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProductRepository productRepository = new ProductRepository();

                Product product = new Product
                {
                    Code = txbCode.Text,
                    Description = txbDescription.Text,
                    Price = Convert.ToDecimal(txbPrice.Text),
                    Quantity = Convert.ToInt32(txbQuantity.Text),
                };
                productRepository.AddProduct(product);
                ClearField();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "Error");
            }
        }
    }
}
