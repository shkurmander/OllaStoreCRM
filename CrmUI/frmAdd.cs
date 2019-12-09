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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void FrmAdd_Load(object sender, EventArgs e)
        {
            //
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                FirstName = txbFirstName.Text,
                LastName = txbLastName.Text,
                Country = txbCountry.Text,
                Address = txbAddress.Text,
                Disqount = trbrDiscount.Value
            };
            if (rbtnMale.Checked) customer.Gender = 1;
            else
                if (rbtnFemale.Checked) customer.Gender = 2;
                else
                   customer.Gender = 3;

            IOController.AddCustomer(customer);

            this.Close();
            
        }
    }
}
