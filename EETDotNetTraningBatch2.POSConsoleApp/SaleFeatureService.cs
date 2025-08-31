using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POSConsoleApp
{
    public class SaleFeatureService
    {
        public void Execute()
        {
            App3DbContext db = new App3DbContext();
            List<TblSaleDetail> products = new List<TblSaleDetail>();

        FirstPage:
            Console.Write("Please enter Product ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            var item = db.TblProducts.FirstOrDefault(x => x.ProductId == id);

            Console.WriteLine($"Product Name : {item.ProductName}");
            Console.WriteLine($"Product Price : {item.Price}");
            Console.Write("Please enter product quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            products.Add(new TblSaleDetail
            {
                ProductId = item.ProductId,
                Quantity = quantity,
                Price = item.Price,
                

            });

            Console.WriteLine("Are you sure want to add more? Y/N");
            string result= Console.ReadLine()!;
            if(result == "Y")
            {
                goto FirstPage;
            }

            TblSale sale = new TblSale() 
            { 
                TotalAmount = products.Sum(x => (x.Price * x.Quantity)),
                SaleDate = DateTime.Now,
                DeleteFlag = false,
                VoucherNo = Guid.NewGuid().ToString()

            };
           
            db.TblSales.Add(sale);
            db.SaveChanges();

            foreach(var product in products)
            {
                product.SaleId = sale.SaleId;
            }

            db.TblSaleDetails.AddRange(products);
            db.SaveChanges();
        }
    }
}
