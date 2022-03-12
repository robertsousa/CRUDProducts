using CRUDProducts.Model;
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
    public partial class FormRead : Form
    {
        Product productInfo;
        
        public FormRead(Product product)
        {
            productInfo = product;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            lblCode.Text = productInfo.Code;
            lblDescription.Text = productInfo.Description;
            lblPrice.Text = productInfo.Price.ToString("C2");
            lblQuantity.Text = productInfo.Quantity.ToString();
        }
    }
}
