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
    public partial class frmLoadProducts : Form
    {

        //  frmMain prevform;
        public frmLoadProducts(frmMain oldform)
        {
            InitializeComponent();

            DataGridViewProducts.DataSource = oldform.mainList.products;
           // DataGridViewProducts.Sort(DataGridViewProducts.Columns[4], ListSortDirection.Ascending);



        }

        private void DataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
