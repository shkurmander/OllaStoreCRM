
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
        CrmContext db;
        public frmMain()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewer = new frmDBView<Customer>(db.Customers);
           // var viewer = new frmDBView();
            viewer.ShowDialog();
        }
    }
}
