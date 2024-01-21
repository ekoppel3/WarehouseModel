namespace UI
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelProductNum = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxPnum = new System.Windows.Forms.TextBox();
            this.textBoxPname = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProductNum
            // 
            this.labelProductNum.AutoSize = true;
            this.labelProductNum.Location = new System.Drawing.Point(19, 97);
            this.labelProductNum.Name = "labelProductNum";
            this.labelProductNum.Size = new System.Drawing.Size(104, 16);
            this.labelProductNum.TabIndex = 12;
            this.labelProductNum.Text = "Product number:";
            this.labelProductNum.Visible = false;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(19, 122);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(93, 16);
            this.labelProductName.TabIndex = 13;
            this.labelProductName.Text = "Product name:";
            this.labelProductName.Visible = false;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(19, 152);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(83, 16);
            this.labelCost.TabIndex = 14;
            this.labelCost.Text = "Cost per unit:";
            this.labelCost.Visible = false;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(17, 183);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(103, 16);
            this.labelAmount.TabIndex = 15;
            this.labelAmount.Text = "Amount in stock:";
            this.labelAmount.Visible = false;
            // 
            // textBoxPnum
            // 
            this.textBoxPnum.Location = new System.Drawing.Point(150, 94);
            this.textBoxPnum.Name = "textBoxPnum";
            this.textBoxPnum.Size = new System.Drawing.Size(100, 22);
            this.textBoxPnum.TabIndex = 16;
            this.textBoxPnum.Visible = false;
            // 
            // textBoxPname
            // 
            this.textBoxPname.Location = new System.Drawing.Point(150, 122);
            this.textBoxPname.Name = "textBoxPname";
            this.textBoxPname.Size = new System.Drawing.Size(100, 22);
            this.textBoxPname.TabIndex = 17;
            this.textBoxPname.Visible = false;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(150, 149);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 22);
            this.textBoxCost.TabIndex = 18;
            this.textBoxCost.Visible = false;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(150, 180);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount.TabIndex = 19;
            this.textBoxAmount.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(279, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "PRODUCTS:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxPname);
            this.Controls.Add(this.textBoxPnum);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductNum);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Controls.SetChildIndex(this.labelProductNum, 0);
            this.Controls.SetChildIndex(this.labelProductName, 0);
            this.Controls.SetChildIndex(this.labelCost, 0);
            this.Controls.SetChildIndex(this.labelAmount, 0);
            this.Controls.SetChildIndex(this.textBoxPnum, 0);
            this.Controls.SetChildIndex(this.textBoxPname, 0);
            this.Controls.SetChildIndex(this.textBoxCost, 0);
            this.Controls.SetChildIndex(this.textBoxAmount, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.buttonModifyEnter, 0);
            this.Controls.SetChildIndex(this.buttonShowIt, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProductNum;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxPnum;
        private System.Windows.Forms.TextBox textBoxPname;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
    }
}