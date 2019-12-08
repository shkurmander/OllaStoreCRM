using CrmBL.Controller;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class frmDBView<T> : Form where T : class
    //public partial class frmDBView : Form
    {
        CrmContext db = new CrmContext();
        public frmDBView()
        {
            InitializeComponent();
            dataGridView.DataSource = db.Customers.Local.ToBindingList();
        }
        
       public frmDBView(DbSet<T> data)
        {
            InitializeComponent();
            dataGridView.DataSource = data.Local.ToBindingList();            
        }
        
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new frmAdd();
            formAdd.ShowDialog();
            //var customer = new Customer()
            //{
            //    Address = "Новосибирск, пк-т, Красный 5",
            //    FirstName = "Анна",
            //    LastName = "Попкина",
            //    Gender = 1,
            //    Country = "Россия",
            //    Disqount = 2
            //};
            //db.Customers.Add(customer);
            //db.SaveChanges();

        }
    }
}
