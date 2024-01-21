namespace UI
{
    partial class Modify
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
            this.labelnumber = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelamount = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelnumber
            // 
            this.labelnumber.AutoSize = true;
            this.labelnumber.Location = new System.Drawing.Point(27, 46);
            this.labelnumber.Name = "labelnumber";
            this.labelnumber.Size = new System.Drawing.Size(107, 16);
            this.labelnumber.TabIndex = 0;
            this.labelnumber.Text = "Product Number:";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.Location = new System.Drawing.Point(27, 84);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(96, 16);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost per unit";
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.Location = new System.Drawing.Point(27, 158);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(103, 16);
            this.labelamount.TabIndex = 3;
            this.labelamount.Text = "Amount in stock:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(169, 46);
            this.textBoxNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(89, 22);
            this.textBoxNumber.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(169, 84);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(89, 22);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(169, 118);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(89, 22);
            this.textBoxCost.TabIndex = 6;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(169, 158);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(89, 22);
            this.textBoxAmount.TabIndex = 7;
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(169, 211);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(89, 24);
            this.buttonModify.TabIndex = 8;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 278);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelnumber);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Modify";
            this.Text = "Modify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modify_FormClosing);
            this.Load += new System.EventHandler(this.Modify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnumber;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonModify;
    }
}