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
    public partial class OrderForm : BaseForm
    {
        OrderBLL orderBll = new OrderBLL();
        public OrderForm()
        {
            InitializeComponent();
        }

        protected override void New_Method()
        {
            labelOrderNumber.Visible = true;
            labelProductNumber.Visible = true;
            labelCustomerID.Visible = true;
            labelQuantity.Visible = true;
            textBoxProductNumber.Visible = true;
            textBoxOrderNumber.Visible = true;
            textBoxCustomerId.Visible = true;
            textBoxQuantity.Visible = true; 
        }
        protected override void Enter_Method()
        {

            labelProductNumber.Visible = false;
            textBoxProductNumber.Visible = false;
            labelOrderNumber.Visible = false;
            textBoxOrderNumber.Visible = false;
            labelCustomerID.Visible = false;
            textBoxCustomerId.Visible = false;
            labelQuantity.Visible=false;
            textBoxQuantity.Visible=false;

            int prodnum = int.Parse(textBoxProductNumber.Text);
            int ordernum = int.Parse(textBoxOrderNumber.Text);
            int customerid = int.Parse(textBoxCustomerId.Text);
            int quantity = int.Parse(textBoxQuantity.Text);
            Order o = new Order(prodnum, customerid, quantity, ordernum);
            try
            {
                orderBll.CreateBLL(o);
                MessageBox.Show($"You have added order {o}");
            }
            catch (NumberAlreadyExists nae)
            {
                MessageBox.Show(nae.Message);
            }/**/
            catch(NumberDoesNotExist nde)
            {
                MessageBox.Show(nde.Message);
            }
            finally
            {
                textBoxProductNumber.Clear();
                textBoxCustomerId.Clear();
                textBoxOrderNumber.Clear();
                textBoxQuantity.Clear();
            }
           

        }//end

        protected override void ShowAll_Method()
        {
            foreach (Order o in orderBll.ReadAll())
            {
                listBox1.Items.Add(o);
            }
        }//end

        protected override void Show_()
        {
            buttonSBC.Visible = true;
            buttonSBP.Visible = true;   
            listBox1.Items.Clear();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSBC_Click(object sender, EventArgs e)
        {
            labelCustomerID.Visible = true;
            textBoxCustomerId.Visible = true;
            buttonShowIt.Visible = true;
            buttonSBP.Visible = false;
            buttonSBC.Visible = false;
        }

        protected override void Show_It()
        {
            try
            { 
                if (textBoxProductNumber.Visible)
                {
                    foreach (Order o in orderBll.ReadByProductBLL(int.Parse(textBoxProductNumber.Text)))
                    {
                        listBox1.Items.Add(o);
                    }
                }
                else if (textBoxCustomerId.Visible)
                {
                    foreach (Order o in orderBll.ReadCustomerBLL(int.Parse(textBoxCustomerId.Text)))
                    {
                        listBox1.Items.Add(o);
                    }
                }
            }
            catch (NumberDoesNotExist ndne)
            {
                MessageBox.Show(ndne.Message);
            }
            finally
            {
                listBox1.Visible = true;
                labelCustomerID.Visible = false;
                textBoxCustomerId.Visible = false;
                labelProductNumber.Visible = false;
                textBoxProductNumber.Visible = false;
                textBoxProductNumber.Clear();
                textBoxCustomerId.Clear();
                buttonShowIt.Visible = false;
            }    
        }

        private void buttonSBP_Click(object sender, EventArgs e)
        {
            labelProductNumber.Visible = true;
            textBoxProductNumber.Visible = true;
            buttonShowIt.Visible = true;
            buttonSBC.Visible = false;
            buttonSBP.Visible = false;
        }

        protected override void Modify()
        {
            labelOrderNumber.Visible = true;
            textBoxOrderNumber.Visible=true;
            buttonModifyEnter.Visible = true;
            labelQuantity.Visible = true;
            textBoxQuantity.Visible = true;
            listBox1.Visible = false;
        }//end

        protected override void Modify_Enter()
        {
            labelOrderNumber.Visible = false;
            labelQuantity.Visible=false;
            textBoxOrderNumber.Visible=false;
            textBoxQuantity.Visible = false;
            buttonModifyEnter.Visible = false;


            try
            {
                Order o = new Order(orderBll.ReadBLL(int.Parse(textBoxOrderNumber.Text)).ProductNumber, orderBll.ReadBLL(int.Parse(textBoxOrderNumber.Text)).CustomerID, int.Parse(textBoxQuantity.Text), int.Parse(textBoxOrderNumber.Text));
              
                orderBll.UpdateOrderBLL(o);
                MessageBox.Show("Order " + o + " has been updated");
            }
            catch (NumberDoesNotExist nd)
            {
                MessageBox.Show(nd.Message);
            }
            finally
            {
                textBoxOrderNumber.Clear();
                textBoxQuantity.Clear();
            }

        }//

        protected override void Remove()
        {
            textBoxOrderNumber.Visible = true;
            labelOrderNumber.Visible = true;
            buttonDelete.Visible = true;
            listBox1.Visible = false;
        }

        protected override void DeleteEnter()
        {
            try
            {
                Order order = orderBll.ReadBLL(int.Parse(textBoxOrderNumber.Text));
                MessageBox.Show("Order " + order + " was deleted");
                orderBll.DeleteOrderBLL(order);
            }
            catch (NumberDoesNotExist)
            {
                MessageBox.Show("Error: This order does not exist.");
            }
            finally
            {
                textBoxOrderNumber.Clear();
                textBoxOrderNumber.Visible = false;
                labelOrderNumber.Visible = false;
                buttonDelete.Visible = false;
            }
            
        }


    }
}
