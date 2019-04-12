namespace TEST
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txbSaving = new System.Windows.Forms.TextBox();
            this.txbChecking = new System.Windows.Forms.TextBox();
            this.txbbank = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.txbcustomers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(815, 20);
            this.textBox1.TabIndex = 0;
            // 
            // txbSaving
            // 
            this.txbSaving.Location = new System.Drawing.Point(32, 40);
            this.txbSaving.Multiline = true;
            this.txbSaving.Name = "txbSaving";
            this.txbSaving.Size = new System.Drawing.Size(221, 166);
            this.txbSaving.TabIndex = 1;
            this.txbSaving.TextChanged += new System.EventHandler(this.txbSaving_TextChanged);
            // 
            // txbChecking
            // 
            this.txbChecking.Location = new System.Drawing.Point(283, 40);
            this.txbChecking.Multiline = true;
            this.txbChecking.Name = "txbChecking";
            this.txbChecking.Size = new System.Drawing.Size(252, 166);
            this.txbChecking.TabIndex = 2;
            // 
            // txbbank
            // 
            this.txbbank.Location = new System.Drawing.Point(35, 229);
            this.txbbank.Multiline = true;
            this.txbbank.Name = "txbbank";
            this.txbbank.Size = new System.Drawing.Size(218, 39);
            this.txbbank.TabIndex = 3;
            // 
            // txbcustomers
            // 
            this.txbcustomers.Location = new System.Drawing.Point(569, 40);
            this.txbcustomers.Multiline = true;
            this.txbcustomers.Name = "txbcustomers";
            this.txbcustomers.Size = new System.Drawing.Size(201, 166);
            this.txbcustomers.TabIndex = 5;
            this.txbcustomers.TextChanged += new System.EventHandler(this.txbcustomers_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 460);
            this.Controls.Add(this.txbcustomers);
            this.Controls.Add(this.txbbank);
            this.Controls.Add(this.txbChecking);
            this.Controls.Add(this.txbSaving);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbSaving;
        private System.Windows.Forms.TextBox txbChecking;
        private System.Windows.Forms.TextBox txbbank;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox txbcustomers;
    }
}

