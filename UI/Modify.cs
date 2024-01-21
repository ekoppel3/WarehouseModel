using BLL;
using Entities;
using System;
using DAL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Modify : Form
    {
        ProductBLL bLL = new ProductBLL();
        public Modify()
        {
            InitializeComponent();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(textBoxNumber.Text), textBoxName.Text, decimal.Parse(textBoxCost.Text), int.Parse(textBoxAmount.Text));
            try
            {
                bLL.UpdateBLL(product);
                MessageBox.Show("Product " + product + "has been updated");
            }
            catch(NumberDoesNotExist)
            {
                MessageBox.Show("Error: Product number does not exist");
            }
            this.Close();
          
        }

        private void Modify_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Modify_Load(object sender, EventArgs e)
        {

        }
    }
}
