using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POS.Domain.Features
{
    public class ProductService
    {
        public List<TblProduct> GetProducts()
        {
            App3DbContext db = new App3DbContext();
            var  lst = db.TblProducts.Where(x => x.DeleteFlag == false).ToList();
        return lst;

        }

        public TblProduct? FindProduct(int id)
        {
            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            return item;
        }

        public int CreateProduct(string productCode, string productName, decimal price)
        {

            TblProduct product = new TblProduct()
            {
                ProductCode = productCode,
                ProductName = productName,
                Price = price
            };

            App3DbContext db = new App3DbContext();
            db.TblProducts.Add(product);
            var result = db.SaveChanges();
            return result;
        }

        public int UpdateProduct(int id,string productCode, string productName, decimal price)
        {
            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            if(item is null)
            {
                return -1;
            }
            
            item.ProductCode = productCode;
            item.ProductName = productName;
            item.Price = price;
            var result = db.SaveChanges();
            return result;

        }

        public int DeleteProduct(int id)
        {
            App3DbContext db = new App3DbContext();
            var item = db.TblProducts.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.ProductId == id);
            if (item is null)
            {
                return -1;
            }
            item.DeleteFlag = true;
            var result = db.SaveChanges();
            return result;
        }
    }
}
