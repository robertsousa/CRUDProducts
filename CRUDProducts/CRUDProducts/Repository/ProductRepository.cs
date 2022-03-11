using CRUDProducts.Data;
using CRUDProducts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProducts.Repository
{
    public class ProductRepository
    {

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
