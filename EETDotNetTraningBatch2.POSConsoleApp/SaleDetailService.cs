using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POSConsoleApp
{
    public class SaleDetailService
    {
        public void Read()
        {
            App3DbContext db = new App3DbContext();
            List<TblSaleDetail> lst = db.TblSaleDetails.ToList();
            foreach (var item in lst)
            {
                Console.WriteLine("SaleDetail Id => " + item.SaleDetailId);
                Console.WriteLine("Sale Id => " + item.SaleId);
                Console.WriteLine("Product Id => " + item.ProductId);
                Console.WriteLine("Quantity => " + item.Quantity);
                Console.WriteLine("Price => " + item.Price);

            }

        }

        public void Edit()
        {

            Console.Write("Enter SaleDetail Id : ");
            string saleDetailId = Console.ReadLine()!;
            bool isInt = int.TryParse(saleDetailId, out int detailId);
            if (!isInt)
            {
                return;
            }

            App3DbContext db = new App3DbContext();
            var item = db.TblSaleDetails.FirstOrDefault(x => x.SaleDetailId == detailId);
            if (item is null)
            {
                return;

            }

            Console.WriteLine("SaleDetail Id => " + item.SaleDetailId);
            Console.WriteLine("Sale Id => " + item.SaleId);
            Console.WriteLine("Product Id => " + item.ProductId);
            Console.WriteLine("Quantity => " + item.Quantity);
            Console.WriteLine("Price => " + item.Price);



        }

        public void Create()
        {
            Console.Write("Enter Sale ID : ");
            string saleId = Console.ReadLine()!;
            bool isInt = int.TryParse(saleId, out int sale);
            if (!isInt)
            {
                return;
            }

            Console.Write("Enter Product ID : ");
            string productId = Console.ReadLine()!;
            bool isIntProduct = int.TryParse(productId, out int pId);
            if (!isIntProduct)
            {
                return;
            }

            Console.Write("Enter Quantity : ");
            string quantity = Console.ReadLine()!;
            bool isIntQty = int.TryParse(quantity, out int qty);
            if (!isIntQty)
            {
                return;
            }

            Console.Write("Enter Price : ");
            string salePrice = Console.ReadLine()!;
            bool isDec = decimal.TryParse(salePrice, out decimal price);
            if (!isDec)
            {
                return;
            }

            TblSaleDetail detail = new TblSaleDetail()
            {
                SaleId = sale,
                ProductId = pId,
                Quantity = qty,
                Price = price,

            };

            App3DbContext db = new App3DbContext();
            db.TblSaleDetails.Add(detail);
            var result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "saving successful" : "saving failed");


        }
    }
}
