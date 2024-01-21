using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using Entities;


namespace UI
{
    public partial class CustomerForm : BaseForm
    {
        CustomerBLL customerBLL = new CustomerBLL();
        public CustomerForm()
        {
            InitializeComponent();
        }

       

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        protected override void New_Method()
        {
            labelCreditCard.Visible = true;
            labelId.Visible = true;
            labelName.Visible = true;
            textBoxCC.Visible = true;   
            textBoxName.Visible = true;
            textBoxId.Visible = true;
        }


        //create
        protected override void Enter_Method()
        {
           
            labelName.Visible = false;
            textBoxName.Visible = false;
            labelCreditCard.Visible = false;
            textBoxCC.Visible = false;
            labelId.Visible=false;
            textBoxId.Visible=false;


            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            CreditCard creditCard=new CreditCard(int.Parse(textBoxCC.Text));

            Customer customer = new Customer(name, id, creditCard);
            try
            {
                customerBLL.CreateBLL(customer);
                MessageBox.Show($"You have added customer {customer}" );
            }
            catch (NumberAlreadyExists nae)
            {
                MessageBox.Show("Error: This customer ID is alredy in our system.");
            }/**/
            textBoxCC.Clear();
            textBoxId.Clear();
            textBoxName.Clear();    
           
        }//end

        protected override void ShowAll_Method()
        {
            foreach (Customer c in customerBLL.ReadAll())
            {
                listBox1.Items.Add(c);
            }
        }//end

        protected override void Show_()
        {
            labelId.Visible = true;
            textBoxId.Visible = true;
            buttonShowIt.Visible = true;
            listBox1.Items.Clear();
        }


        protected override void Show_It()
        {
            listBox1.Visible = true;
            labelId.Visible = false;
            textBoxId.Visible = false;
            buttonShowIt.Visible = false;


            int num = int.Parse(textBoxId.Text);
            try
            {
                listBox1.Items.Add(customerBLL.ReadBLL(num));
            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: This customer id is not in the system.");
            }
            textBoxCC.Clear();
            textBoxId.Clear();
            textBoxName.Clear();
        }
        private void buttonShowEnter_Click(object sender, EventArgs e)
        {
           
        }//end

        protected override void Modify()
        {
            buttonModifyEnter.Visible = true;
            labelCreditCard.Visible = true;
            labelId.Visible=true;
            labelName.Visible=true;
            textBoxCC.Visible = true;
            textBoxId.Visible=true;
            textBoxName.Visible=true;
            listBox1.Visible = false;
        }//end

        protected override void Modify_Enter()
        {
            textBoxCC.Visible = false;
            textBoxId.Visible = false;
            textBoxName.Visible = false;
            labelCreditCard.Visible = false;
            labelId.Visible = false;
            labelName.Visible = false;
            buttonModifyEnter.Visible=false;    

            int id = int.Parse(textBoxId.Text);
            string name = textBoxName.Text;
            CreditCard creditCard = new CreditCard(int.Parse(textBoxCC.Text));

            Customer customer = new Customer(name, id, creditCard);


            try
            {
                customerBLL.UpdateBLL(customer);
                MessageBox.Show("Customer " + customer + "has been updated");
            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: Customer is not in the system.");
            }
            textBoxName.Clear();
            textBoxId.Clear();
            textBoxCC.Clear();
            

        }

        protected override void Remove()
        {
            textBoxId.Visible = true;
            labelId.Visible = true;
            buttonDelete.Visible = true;
            listBox1.Visible = false;
        }

        protected override void DeleteEnter()
        {
            try
            {
                MessageBox.Show("Customer " + customerBLL.ReadBLL(int.Parse(textBoxId.Text)) + " was deleted");
                customerBLL.DeleteBLL(int.Parse(textBoxId.Text));

            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: this customer id is not in the system");
            }
            textBoxId.Text = null;
            textBoxId.Visible=false;
            labelId.Visible=false;
            buttonDelete.Visible=false;
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
    }

