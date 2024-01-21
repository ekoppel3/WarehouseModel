using BLL;
using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace UI
{
    public partial class Create : Form
    {
        ProductBLL bLL = new ProductBLL();
        public Create()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Product product = new Product(int.Parse(textBoxProductNumber.Text), textBoxProductName.Text, decimal.Parse(textBoxCost.Text), int.Parse(textBoxAmount.Text));
            try
            {
                bLL.CreateBLL(product);
                MessageBox.Show("product was created: " + product);
            }
            catch(NumberAlreadyExists)
            {
                MessageBox.Show("Error: Product number already exists");
            }
            
            this.Close();

           

        }

        private void Create_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            /* Application.Exit();*/
        }
    }
}
