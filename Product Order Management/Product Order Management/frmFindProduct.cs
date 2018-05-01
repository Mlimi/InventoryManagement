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
    public partial class frmFindProduct : Form

    {
        frmMain olderForm = new frmMain();
        ProductList prevList = new ProductList();

       public frmFindProduct(frmMain oldForm)
        {
            InitializeComponent();
            olderForm = oldForm;
            prevList = oldForm.mainList;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string pc = txtFindProductCode.Text;
            Product helper = new Product();
            if (olderForm.mainList.findProduct(pc) != null)
            {
                helper = olderForm.mainList.findProduct(pc);
                MessageBox.Show(helper.DisplayText());
            }
        }
    }
}
