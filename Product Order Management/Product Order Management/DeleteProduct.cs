using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Product_Order_Management
{
    public partial class DeleteProduct : Form
    {
        frmMain olderForm = new frmMain();
        ProductList prevList = new ProductList();

        
        public DeleteProduct(frmMain oldForm)
        {
            InitializeComponent();

            olderForm = oldForm;
            prevList = oldForm.mainList;


        }

        private void DeleteProduct_Load(object sender, EventArgs e)
        {
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         

        public void btnConfirmDelete_Click(object sender, EventArgs e)
        { 
            string pc = Convert.ToString(txtProductCode.Text);
            //delete from the mainlist
            olderForm.mainList.deleteProduct(pc);
            //delete from the orderby profit list
       
            MessageBox.Show("The product was successfully Deleted from the Inventory", "Confrimation");
            txtProductCode.Text = "";
        }
    }
}
