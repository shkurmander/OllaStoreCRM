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
    public partial class frmAddSource : Form
    {
        public frmAddSource()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var source = new Source()
            {
                Name = txbName.Text,
                Link = txbLink.Text,
                Taxes = Convert.ToSingle(txbTaxes.Text)                
            };
            
            IOController.AddRecord(source, "Sources");


            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
