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
    public partial class frmSalesStatistics : Form
    {

        frmMain olderForm = new frmMain();
        ProductList prevList = new ProductList();

        public frmSalesStatistics(frmMain oldForm)
        {
            olderForm = oldForm;
            prevList = oldForm.mainList;

            InitializeComponent();
        }

        private void frmSalesStatistics_Load(object sender, EventArgs e)
        {
            dataGridViewSalesStatistics.DataSource = olderForm.mainList.products;

        }

        private void dataGridViewSalesStatistics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
