using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POSConsoleApp
{
    public class SaleService
    {
        public void Read()
        {
            App3DbContext db = new App3DbContext();
            List<TblSale> lst = db.TblSales.Where(x => x.DeleteFlag == false).ToList();
            foreach (var item in lst)
            {
                Console.WriteLine("Sale Id => " + item.SaleId);
                Console.WriteLine("Voucher No => " + item.VoucherNo);
                Console.WriteLine("Sale Date => " + item.SaleDate);
                Console.WriteLine("Total Amount => " + item.TotalAmount);
            }

        }

        public void Edit()
        {
            Console.Write("Enter SaleId : ");
            string saleId = Console.ReadLine()!;
            bool isInt = int.TryParse(saleId, out int id);
            if (!isInt)
            {
                return;
            }

            App3DbContext db = new App3DbContext();
            var item = db.TblSales.Where(x => x.DeleteFlag == false).FirstOrDefault(x => x.SaleId == id);
            if (item is null)
            {
                return;
            }

            Console.WriteLine("Sale Id => " + item.SaleId);
            Console.WriteLine("Voucher No => " + item.VoucherNo);
            Console.WriteLine("Sale Date => " + item.SaleDate);
            Console.WriteLine("Total Amount => " + item.TotalAmount);

        }

        public void Create()
        {
            Console.Write("Enter Voucher No : ");
            string voucherNo = Console.ReadLine()!;
            Console.Write("Enter Sale Date : ");
            string saleDate = Console.ReadLine()!;
            bool isDate = DateTime.TryParse(saleDate, out DateTime date);
            if (!isDate)
            {
                return;
            }

            Console.Write("Enter Total Amount : ");
            string totalAmt = Console.ReadLine()!;
            bool isDec = Decimal.TryParse(totalAmt, out decimal amt);
            if (!isDec)
            {
                return;
            }

            TblSale sale = new TblSale()
            {
                VoucherNo = voucherNo,
                SaleDate = date,
                TotalAmount = amt,

            };

            App3DbContext db = new App3DbContext();
            db.TblSales.Add(sale);
            var result = db.SaveChanges();
            Console.WriteLine(result > 0 ? "saving successful" : "saving failed");

        }
    }
}
