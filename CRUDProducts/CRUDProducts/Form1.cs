using CRUDProducts.Forms;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCreate formCreate = new FormCreate();
            formCreate.ShowDialog();
            _ = LoadDataGridAsync();
        }

        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(DgvProducts.SelectedRows.Count > 0)
            {
                ProductRepository repository = new ProductRepository();

                int idProduct = Convert.ToInt32(DgvProducts.SelectedRows[0].Cells[0].Value);

                Product product = repository.SelectProduct(idProduct);

                FormUpdate formUpdate = new FormUpdate(product);
                formUpdate.ShowDialog();

                _ = LoadDataGridAsync();
            }
            else
            {
                MessageBox.Show("Please select a row.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (DgvProducts.SelectedRows.Count > 0)
            {
                ProductRepository repository = new ProductRepository();

                int idProduct = Convert.ToInt32(DgvProducts.SelectedRows[0].Cells[0].Value);

                Product product = repository.SelectProduct(idProduct);

                FormRead formRead = new FormRead(product);
                formRead.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DgvProducts.SelectedRows.Count > 0)
            {
                ProductRepository productRepository = new ProductRepository();
                
                int IdProductToRemove = Convert.ToInt32(DgvProducts.SelectedRows[0].Cells[0].Value);

                Product product = productRepository.SelectProduct(IdProductToRemove);

                var result = MessageBox.Show("Do you really want to delete this item?", "Deleting...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               
                if (result == DialogResult.OK)
                {
                    productRepository.DeleteProduct(product);
                    MessageBox.Show("Item deleted...","Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    _ = LoadDataGridAsync();
                }
            }
            else
            {
                MessageBox.Show("Please select a row. ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
