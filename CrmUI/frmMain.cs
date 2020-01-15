
using CrmBL.Controller;
using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CrmUI
{
    public partial class frmMain : Form
    {
        CrmContext db = IOController.GetContext();

        public frmMain()
        {
            InitializeComponent();
            /*lbTest.Text = "эйуася";
            IOController.test = lbTest.Text;
            MessageBox.Show(IOController.test);*/
            
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var test = db.Database.Log;
            //MessageBox.Show(db.Customers.Local.FirstOrDefault().FirstName);
            UIVars.TableName = "Customers";
            var viewer = new frmDBView<Customer>(db.Customers);
           
           // var viewer = new frmDBView();
            viewer.ShowDialog();
        }
    }
}
