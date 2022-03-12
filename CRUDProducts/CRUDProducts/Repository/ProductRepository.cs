using CRUDProducts.Data;
using CRUDProducts.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProducts.Repository
{
    public class ProductRepository
    {
        public async void AddProduct(Product product)
        {
            using (CRUDContext context = new CRUDContext())
            {
                context.Entry(product).State = EntityState.Added;               
                await context.SaveChangesAsync();
            }
        }

        public Product SelectProduct(int id)
        {
            using (CRUDContext context = new CRUDContext())
            {
                return context.Products.SingleOrDefault(p => p.Id == id);
            }
        }

        public async void UpdateProduct(Product product)
        {
            using (CRUDContext context = new CRUDContext())
            {
                context.Entry(product).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
        }

        public async void DeleteProduct(Product product)
        {
            using (CRUDContext context = new CRUDContext())
            {                
                context.Entry(product).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public Task<List<Product>> SelectAll()
        {
            return Task.Run(() =>
            {
                using (CRUDContext context = new CRUDContext())
                {
                    return context.Products.ToList();
                }
            });
        }
    }
}
