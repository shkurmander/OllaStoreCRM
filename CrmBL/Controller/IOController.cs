using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBL.Controller
{
    public static class IOController
    {
        
        public static void AddCustomer(Customer record) 
        {
            CrmContext db = new CrmContext();
            db.Customers.Add(record);
            db.SaveChanges();
        }
        public static CrmContext GetContext()
        {
            var db = new CrmContext();
            db.Customers.Load();
            Console.WriteLine(db.Customers.Local.FirstOrDefault().FirstName);
            return db; 
        }

        static IOController()
        {
          
        }
    }
}
