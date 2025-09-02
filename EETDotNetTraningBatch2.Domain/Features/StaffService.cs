using EETDotNetTraningBatch2.POSDatabase.App3DbContextModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EETDotNetTraningBatch2.POS.Domain.Features
{
    public class StaffService
    {
        public int StaffRegister()
        {
            Console.WriteLine("Enter Staff Code : ");
            string staffcode = Console.ReadLine()!;
            Console.WriteLine("Enter Staff Name : ");
            string staffName = Console.ReadLine()!;
            Console.WriteLine("Staff's Email Address : ");
            string staffEmail = Console.ReadLine()!;
            Console.WriteLine("Staff's Password : ");
            string staffPassword = Console.ReadLine()!;
            Console.WriteLine("Staff's Position : ");
            string staffPosition = Console.ReadLine()!;
            Console.WriteLine("Staff's Phone Number : ");
            string staffPhone = Console.ReadLine()!;

            var staff = new TblStaff()
            {
                StaffCode = staffcode,
                StaffName = staffName,
                EmailAddress = staffEmail,
                Password = staffPassword,
                Position = staffPosition,
                MobileNo = staffPhone,
                IsDelete = false
            };

            App3DbContext db = new App3DbContext();
            db.TblStaffs.Add(staff);
            int result = db.SaveChanges();
            return result;

        }

        public void Read()
        {
            App3DbContext db = new App3DbContext();
            var lst = db.TblStaffs.ToList();

        }
    }
}
