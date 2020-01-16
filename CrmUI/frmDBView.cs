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
    //public partial class frmDBView<T> : Form where T : class
    public partial class frmDBView : Form
    {
       
        public frmDBView()
        {
            InitializeComponent();
            //dataGridView.DataSource = db.Customers.Local.ToBindingList();
            UpdateGrid();
        }
        
       /*public frmDBView(DbSet<T> data)
        {
            InitializeComponent();
            /*CrmContext db = new CrmContext();
                        MessageBox.Show(data.Local.First);
            //var first = data.Local.First();
            db.Database.Log = Console.Write;
            dataGridView.Columns.Add("ID","Id");
            dataGridView.Columns.Add("FristName", "Имя");
            dataGridView.Columns.Add("LastName", "Фамилия");
            dataGridView.Columns.Add("Gender", "Пол");
            dataGridView.Columns.Add("Country", "Страна");
            dataGridView.Columns.Add("Address", "Адрес");
            dataGridView.Columns.Add("Discount", "Скидка");

            dataGridView.Rows.Add(db.Customers.FirstOrDefault());

            UpdateGrid();


        }*/
        
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            switch (UIVars.TableName)
            {
                case "Customers":
                    var frmAdd = new frmAdd();
                    frmAdd.FormClosing += new FormClosingEventHandler(frmAddClosingHandler);
                    frmAdd.ShowDialog(); break;
                case "Sources":
                    var frmAddSource = new frmAddSource();
                    frmAddSource.FormClosing += new FormClosingEventHandler(frmAddClosingHandler);
                    frmAddSource.ShowDialog(); break;


                default: throw new ArgumentException("Некоррректное имя таблицы");

            }
            
           
        }

        private void frmAddClosingHandler(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            var db = IOController.GetContext();
            switch (UIVars.TableName)
            {
                case "Customers":
                    db.Customers.Load();
                    dataGridView.DataSource = db.Customers.Local.ToBindingList();
                    break;
                case "Sources":
                    db.Sources.Load();
                    dataGridView.DataSource = db.Sources.Local.ToBindingList();
                    break;
                default:
                    break;
            }
            
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
