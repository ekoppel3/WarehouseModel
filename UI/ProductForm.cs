using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BLL;
using DAL;

namespace UI
{
    public partial class ProductForm : BaseForm
    {
        ProductBLL productBLL = new ProductBLL();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        protected override void New_Method()
        {
            labelProductNum.Visible = true;
            labelProductName.Visible = true;
            listBox1.Visible = false;
            labelCost.Visible = true;
            labelAmount.Visible = true;
            textBoxPnum.Visible = true;
            textBoxPname.Visible = true;
            textBoxCost.Visible = true;
            textBoxAmount.Visible = true;   
        }


        //create
        protected override void Enter_Method()
        {
            labelProductNum.Visible = false;
            labelProductName.Visible = false;
            labelCost.Visible = false;
            labelAmount.Visible = false;
            textBoxPnum.Visible = false;
            textBoxPname.Visible = false;
            textBoxCost.Visible = false;
            textBoxAmount.Visible = false;
            
            int num = int.Parse(textBoxPnum.Text);
            string name = textBoxPname.Text;
            decimal cost = decimal.Parse(textBoxCost.Text);
            int amount = int.Parse(textBoxAmount.Text);

            Product product = new Product(num, name, cost, amount);
            try
            {
                productBLL.CreateBLL(product);
                MessageBox.Show($"You have added product {product}");
            }
            catch (NumberAlreadyExists nae)
            {
                MessageBox.Show("Error: This product number is alredy in our system.");
            }
            textBoxPnum.Clear();
            textBoxPname.Clear();
            textBoxCost.Clear();
            textBoxAmount.Clear();

        }//end
        protected override void ShowAll_Method()
        {
            listBox1.Visible = true;
            listBox1.Items.Clear();
            textBoxPnum.Visible = false;
            labelProductNum.Visible = false;
           

            foreach (Product p in productBLL.ReadAll())
            {
                listBox1.Items.Add(p);
            }
        }
        protected override void Show_()
        {
            listBox1.Items.Clear();
            labelProductNum.Visible = true;
            textBoxPnum.Visible = true;
            buttonShowIt.Visible = true;

        }
        protected override void Show_It()
        {
            listBox1.Visible = true;
            labelProductNum.Visible = false;
            textBoxPnum.Visible = false;
            buttonShowIt.Visible = false;


            int num = int.Parse(textBoxPnum.Text);
            try
            {
                listBox1.Items.Add(productBLL.ReadBLL(num));
            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: This product number does not exist");
            }
            textBoxPnum.Text = string.Empty;
        }

    
        protected override void Modify()
        {
            buttonModifyEnter.Visible = true;
            labelProductNum.Visible = true;
            labelProductName.Visible = true;
            labelAmount.Visible = true;
            labelCost.Visible = true;
           
            textBoxPnum.Visible = true;
            textBoxPname.Visible = true;
            textBoxAmount.Visible = true;
            textBoxCost.Visible = true;

            listBox1.Visible = false;

        }
        protected override void Modify_Enter()
        {
            textBoxPname.Visible = false;
            textBoxPnum.Visible = false;
            textBoxAmount.Visible = false;
            textBoxCost.Visible = false;
            labelProductNum.Visible = false;
            labelProductName.Visible = false;
            labelCost.Visible = false;
            labelAmount.Visible=false;
            buttonModifyEnter.Visible = false;

            int num = int.Parse(textBoxPnum.Text);
            string name = textBoxPname.Text;
            decimal cost = decimal.Parse(textBoxCost.Text);
            int amount= int.Parse(textBoxAmount.Text);

           Product product = new Product(num, name, cost, amount);


            try
            {
                productBLL.UpdateBLL(product);
                MessageBox.Show("Product " + product + "has been updated");
            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: product is not in the system.");
            }
            textBoxPname.Clear();
            textBoxPnum.Clear();
            textBoxCost.Clear();
            textBoxAmount.Clear();


        }
        protected override void Remove()
        {
            textBoxPnum.Visible = true;
            labelProductNum.Visible = true;
            buttonDelete.Visible = true;
            listBox1.Visible = false;
        }

        protected override void DeleteEnter()
        {
            buttonDelete.Visible = false;
            labelProductNum.Visible= false; 
            textBoxPnum.Visible= false; 
            try
            {
                MessageBox.Show("Product " + productBLL.ReadBLL(int.Parse(textBoxPnum.Text)) + " was deleted");
               productBLL.DeleteBLL(int.Parse(textBoxPnum.Text));

            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: product number does not exist");
            }
            textBoxPnum.Text = null;

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}

