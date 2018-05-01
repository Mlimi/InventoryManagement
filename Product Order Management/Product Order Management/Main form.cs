using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Order_Management
{
    public partial class frmMain : Form
    {
        public ProductList mainList = new ProductList();
        //made a new list to get the by profit order
       
        public frmMain()
        {

            InitializeComponent();

            mainList.products = mainList.GetProducts("Id");
            
        }

        private void btnSalesStatistics_Click(object sender, EventArgs e)
        {
            mainList.GetProducts("Profit");
            frmSalesStatistics form = new frmSalesStatistics(this);
            form.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddNewProduct form = new frmAddNewProduct(this);
            form.ShowDialog();
        }

        private void btnLoadProducts_Click(object sender, EventArgs e)
        {
            mainList.GetProducts("QuantitySold");
            frmLoadProducts form = new frmLoadProducts(this);
           
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct form = new DeleteProduct(this);

            form.ShowDialog();

        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            frmFindProduct form = new frmFindProduct(this);

            form.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutFrom form = new AboutFrom();

            form.ShowDialog();
        }
    }
}
