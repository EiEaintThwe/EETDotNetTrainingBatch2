using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POS.Domain.Features
{
    public class SaleService
    {
        public TblProduct FindProduct(int id)
        {
            App3DbContext db = new App3DbContext();

            var item = db.TblProducts.FirstOrDefault(x => x.ProductId == id);
            return item;
        }

        public int Sale(List<TblSaleDetail> products)
        {
            App3DbContext db = new App3DbContext();
            //List<TblSaleDetail> products = new List<TblSaleDetail>();

            #region generate sale summary and create sale summary
            TblSale sale = new TblSale()
            {
                TotalAmount = products.Sum(x => (x.Price * x.Quantity)),
                SaleDate = DateTime.Now,
                DeleteFlag = false,
                VoucherNo = Guid.NewGuid().ToString()

            };

            db.TblSales.Add(sale);
            db.SaveChanges();
            #endregion
            

            #region modify sale detail and create sale detail
            foreach (var product in products)
            {
                product.SaleId = sale.SaleId;
            }

            db.TblSaleDetails.AddRange(products);
            var result = db.SaveChanges();

            #endregion
            return result;

        }

        public List<TblSale> SaleListing()
        {
            App3DbContext db = new App3DbContext();
            var result = db.TblSales.ToList();
            return result;
        }

        public List<TblSaleDetail> SaleDetailListing()
        {
            App3DbContext db = new App3DbContext();
            var result = db.TblSaleDetails.ToList();
            return result;

        }
    }
}
