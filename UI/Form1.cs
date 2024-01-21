using BLL;
using System;
using DAL;
using Entities;
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
    public partial class Form1 : Form
    {
        ProductBLL bLL = new ProductBLL();
        public Form1()
        {
            InitializeComponent();
        }


        //it's for show
        private void button1_Click(object sender, EventArgs e)
        {
            labelProductNumber.Visible = true;
            textBoxShow.Visible = true;
            buttonEnterShow.Visible = true;
            listBoxProducts.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnterShow_Click(object sender, EventArgs e)
        {
            listBoxProducts.Visible = true;
            labelProductNumber.Visible = false;
            textBoxShow.Visible = false;
            buttonEnterShow.Visible=false;
           

            int num = int.Parse(textBoxShow.Text);
            try
            {
                listBoxProducts.Items.Add(bLL.ReadBLL(num));
            }
            catch(NumberDoesNotExist)
            {
                MessageBox.Show("Error: This product number does not exist");
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Create create = new Create();
            create.Show();
            this.Hide();
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBoxProducts.Visible = true;
            listBoxProducts.Items.Clear();
            textBoxShow.Visible = false;
            labelProductNumber.Visible = false;
            buttonDelete.Visible = false;
            buttonEnterShow.Visible = false;

            foreach (Product p in bLL.ReadAll())
            {
                listBoxProducts.Items.Add(p);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            textBoxShow.Visible = true;
            labelProductNumber.Visible = true;
            buttonDelete.Visible = true;
            listBoxProducts.Visible = false;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                MessageBox.Show("Product " + bLL.ReadBLL(int.Parse(textBoxShow.Text)) + " was deleted");
                bLL.DeleteBLL(int.Parse(textBoxShow.Text));
                
            }
            catch(NumberDoesNotExist)
            {
                MessageBox.Show("Error: product number does not exist");
            }
            textBoxShow.Text = null;
            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modify modify = new Modify();
            modify.Show();
           
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
