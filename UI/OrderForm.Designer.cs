namespace UI
{
    partial class OrderForm
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
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelProductNumber = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxCustomerId = new System.Windows.Forms.TextBox();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.buttonSBC = new System.Windows.Forms.Button();
            this.buttonSBP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(301, 28);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Location = new System.Drawing.Point(33, 105);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(95, 16);
            this.labelOrderNumber.TabIndex = 12;
            this.labelOrderNumber.Text = "Order Number:";
            this.labelOrderNumber.Visible = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(33, 182);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(95, 16);
            this.labelQuantity.TabIndex = 13;
            this.labelQuantity.Text = "Order Quantity:";
            this.labelQuantity.Visible = false;
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(33, 155);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(81, 16);
            this.labelCustomerID.TabIndex = 14;
            this.labelCustomerID.Text = "Customer Id:";
            this.labelCustomerID.Visible = false;
            // 
            // labelProductNumber
            // 
            this.labelProductNumber.AutoSize = true;
            this.labelProductNumber.Location = new System.Drawing.Point(33, 130);
            this.labelProductNumber.Name = "labelProductNumber";
            this.labelProductNumber.Size = new System.Drawing.Size(107, 16);
            this.labelProductNumber.TabIndex = 15;
            this.labelProductNumber.Text = "Product Number:";
            this.labelProductNumber.Visible = false;
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.Location = new System.Drawing.Point(155, 99);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxOrderNumber.TabIndex = 16;
            this.textBoxOrderNumber.Visible = false;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(155, 183);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxQuantity.TabIndex = 17;
            this.textBoxQuantity.Visible = false;
            // 
            // textBoxCustomerId
            // 
            this.textBoxCustomerId.Location = new System.Drawing.Point(155, 155);
            this.textBoxCustomerId.Name = "textBoxCustomerId";
            this.textBoxCustomerId.Size = new System.Drawing.Size(100, 22);
            this.textBoxCustomerId.TabIndex = 18;
            this.textBoxCustomerId.Visible = false;
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Location = new System.Drawing.Point(155, 127);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxProductNumber.TabIndex = 19;
            this.textBoxProductNumber.Visible = false;
            // 
            // buttonSBC
            // 
            this.buttonSBC.Location = new System.Drawing.Point(22, 384);
            this.buttonSBC.Name = "buttonSBC";
            this.buttonSBC.Size = new System.Drawing.Size(140, 23);
            this.buttonSBC.TabIndex = 20;
            this.buttonSBC.Text = "Show by Customer";
            this.buttonSBC.UseVisualStyleBackColor = true;
            this.buttonSBC.Visible = false;
            this.buttonSBC.Click += new System.EventHandler(this.buttonSBC_Click);
            // 
            // buttonSBP
            // 
            this.buttonSBP.Location = new System.Drawing.Point(22, 413);
            this.buttonSBP.Name = "buttonSBP";
            this.buttonSBP.Size = new System.Drawing.Size(140, 23);
            this.buttonSBP.TabIndex = 21;
            this.buttonSBP.Text = "Show by Product";
            this.buttonSBP.UseVisualStyleBackColor = true;
            this.buttonSBP.Visible = false;
            this.buttonSBP.Click += new System.EventHandler(this.buttonSBP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(298, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Orders:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI.Properties.Resources.images__1_2;
            this.pictureBox2.Location = new System.Drawing.Point(1003, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSBP);
            this.Controls.Add(this.buttonSBC);
            this.Controls.Add(this.textBoxProductNumber);
            this.Controls.Add(this.textBoxCustomerId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelProductNumber);
            this.Controls.Add(this.labelCustomerID);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelOrderNumber);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Controls.SetChildIndex(this.listBox1, 0);
            this.Controls.SetChildIndex(this.buttonModifyEnter, 0);
            this.Controls.SetChildIndex(this.buttonShowIt, 0);
            this.Controls.SetChildIndex(this.buttonDelete, 0);
            this.Controls.SetChildIndex(this.labelOrderNumber, 0);
            this.Controls.SetChildIndex(this.labelQuantity, 0);
            this.Controls.SetChildIndex(this.labelCustomerID, 0);
            this.Controls.SetChildIndex(this.labelProductNumber, 0);
            this.Controls.SetChildIndex(this.textBoxOrderNumber, 0);
            this.Controls.SetChildIndex(this.textBoxQuantity, 0);
            this.Controls.SetChildIndex(this.textBoxCustomerId, 0);
            this.Controls.SetChildIndex(this.textBoxProductNumber, 0);
            this.Controls.SetChildIndex(this.buttonSBC, 0);
            this.Controls.SetChildIndex(this.buttonSBP, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelProductNumber;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxCustomerId;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.Button buttonSBC;
        private System.Windows.Forms.Button buttonSBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}