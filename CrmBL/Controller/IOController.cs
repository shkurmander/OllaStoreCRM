using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmBL.Controller
{
    public static class IOController
    {
        public static string test { get; set; }
        public static void AddRecord(Object record, string table) 
        {
            CrmContext db = new CrmContext();
            switch (table)
            {
                case "Customers" : db.Customers.Add((Customer)record);  break;
                case "Sources" : db.Sources.Add((Source)record);  break;


                default: throw new ArgumentException("Некоррректное имя таблицы");                    
            }
            
            db.SaveChanges();
        }
        public static CrmContext GetContext()
        {
            var db = new CrmContext();
            //db.Customers.Load();
            //Console.WriteLine(db.Customers.Local.FirstOrDefault().FirstName); //тест чтения из бд
            return db; 
        }

        static IOController()
        {
          
        }
    }
}
