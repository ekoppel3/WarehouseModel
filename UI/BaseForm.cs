using System;
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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        protected virtual void Remove()
        {

        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            Modify();
        }

        protected virtual void Modify()
        {

        }

        protected virtual void Show_()
        {

        }
        private void buttonShow_Click(object sender, EventArgs e)
        {
            Show_();

        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Visible = true;
            ShowAll_Method();
            
            
            

        }

        

        private void buttonNew_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

           // choice = "New";
            New_Method();
            buttonEnter.Visible = true;
            //DisableChoiceButtons();
        }

        
        protected virtual void ShowAll_Method()
        {

        }
        protected virtual void New_Method()
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            buttonEnter.Visible = false;
            Enter_Method();
        }

        protected virtual void Enter_Method()
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowIt_Click(object sender, EventArgs e)
        {
            Show_It();
        }

        protected virtual void Show_It()
        {

        }

        private void buttonModifyEnter_Click(object sender, EventArgs e)
        {
            Modify_Enter();
        }

        protected virtual void Modify_Enter()
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEnter();
        }
        protected virtual void DeleteEnter()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
 
            this.Hide();
            HomeForm home = new HomeForm();

            home.Show();

        }

    }
}
