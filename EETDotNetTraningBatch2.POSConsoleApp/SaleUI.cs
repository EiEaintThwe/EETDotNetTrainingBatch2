using EETDotNetTraningBatch2.POS.Domain.Features;
using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POSConsoleApp
{
    public class SaleUI
    {
        public void Execute()
        {
        Result:
            Console.WriteLine("Sale Menu");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. New sale");
            Console.WriteLine("2. Sale List");
            Console.WriteLine("3. Sale Detail");
            Console.WriteLine("4. Exit");

            Console.WriteLine("-----------------------------------");

            Console.Write("Choose Menu : ");
            string result = Console.ReadLine()!;
            bool isInt = int.TryParse(result, out int no);
            if (!isInt)
            {
                Console.WriteLine("Invalid Sale Menu. Please choose 1 to 4");
                goto Result;
            }
            Console.WriteLine("-----------------------------------");

            EnumSaleMenu menu = (EnumSaleMenu)no;
            switch (menu)
            {
                
                case EnumSaleMenu.NewSale:
                    NewSale();
                    break;
                case EnumSaleMenu.SaleList:
                    SaleList();
                    break;
                case EnumSaleMenu.SaleDetail:
                    SaleDetail();
                    break;
                case EnumSaleMenu.Exit:
                    goto End;
                case EnumSaleMenu.None:
                default:
                    Console.WriteLine("Invalid Sale Menu. Please choose 1 to 4");
                    goto Result;
                  
            }
            Console.WriteLine("-----------------------------------");
            goto Result;

        End:
            Console.WriteLine("Exiting Product Menu....");
        }
    
        public void NewSale()
        {
            SaleService saleService = new SaleService();
            //App3DbContext db = new App3DbContext();
            List<TblSaleDetail> products = new List<TblSaleDetail>();

        FirstPage:

            #region prepare product
            Console.Write("Please enter Product ID : ");
            int id = Convert.ToInt32(Console.ReadLine());
            //var item = db.TblProducts.FirstOrDefault(x => x.ProductId == id);
            var item = saleService.FindProduct(id);

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

            #endregion

            #region add more product or continue

            Console.WriteLine("Are you sure want to add more? Y/N");
            string confirm = Console.ReadLine()!;
            if (confirm == "Y")
            {
                goto FirstPage;
            }

            #endregion

            //TblSale sale = new TblSale() 
            //{ 
            //    TotalAmount = products.Sum(x => (x.Price * x.Quantity)),
            //    SaleDate = DateTime.Now,
            //    DeleteFlag = false,
            //    VoucherNo = Guid.NewGuid().ToString()

            //};

            //db.TblSales.Add(sale);
            //db.SaveChanges();

            //foreach(var product in products)
            //{
            //    product.SaleId = sale.SaleId;
            //}

            //db.TblSaleDetails.AddRange(products);
            //db.SaveChanges();

            #region sale process
            int result = saleService.Sale(products);
            Console.WriteLine(result > 0 ? "Sale Processing Success" : "Failed");
            Console.WriteLine("------------------------------------------------------");
            #endregion
        }

        //private TblProduct FindProduct(int id)
        //{
        //    App3DbContext db = new App3DbContext();

        //    var item = db.TblProducts.FirstOrDefault(x => x.ProductId == id);
        //    return item;
        //}

        //private void Sale(List<TblSaleDetail> products)
        //{
        //    App3DbContext db = new App3DbContext();
        //    //List<TblSaleDetail> products = new List<TblSaleDetail>();

        //    #region generate sale summary and create sale summary
        //    TblSale sale = new TblSale()
        //    {
        //        TotalAmount = products.Sum(x => (x.Price * x.Quantity)),
        //        SaleDate = DateTime.Now,
        //        DeleteFlag = false,
        //        VoucherNo = Guid.NewGuid().ToString()

        //    };

        //    db.TblSales.Add(sale);
        //    db.SaveChanges();
        //    #endregion

        //    #region modify sale detail and create sale detail
        //    foreach (var product in products)
        //    {
        //        product.SaleId = sale.SaleId;
        //    }

        //    db.TblSaleDetails.AddRange(products);
        //    db.SaveChanges();

        //    #endregion

        //}

        public void SaleList()
        {
            SaleService saleService = new SaleService();
            var lst = saleService.SaleListing();
            foreach (var item in lst)
            {
                Console.WriteLine("Sale ID : " + item.SaleId);
                Console.WriteLine("Voucher No : " + item.VoucherNo);
                Console.WriteLine("Sale Date : " + item.SaleDate);
                Console.WriteLine("Total Amount : " + item.TotalAmount);
            }
        }

        public void SaleDetail()
        {
            SaleService saleService = new SaleService();
            var lst = saleService.SaleDetailListing();
            foreach(var item in lst)
            {
                Console.WriteLine("SaleDetail Id : " + item.SaleDetailId);
                Console.WriteLine("Sale Id : " + item.SaleId);
                Console.WriteLine("Product Id : "+ item.ProductId);
                Console.WriteLine("Quantity : "+ item.Quantity);
                Console.WriteLine("Price : "+ item.Price);
            }
        }

    }
    public enum EnumSaleMenu
    {
        None,
        NewSale,
        SaleList,
        SaleDetail,
        Exit
    }
}

   

