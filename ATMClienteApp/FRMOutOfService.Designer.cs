namespace ATMClienteApp
{
    partial class FRMOutOfService
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
            this.components = new System.ComponentModel.Container();
            this.txbinfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSecret = new System.Windows.Forms.Button();
            this.txadmname = new System.Windows.Forms.TextBox();
            this.txbadmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btBackToWork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbinfo
            // 
            this.txbinfo.BackColor = System.Drawing.Color.DimGray;
            this.txbinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbinfo.ForeColor = System.Drawing.Color.Maroon;
            this.txbinfo.Location = new System.Drawing.Point(96, 77);
            this.txbinfo.Multiline = true;
            this.txbinfo.Name = "txbinfo";
            this.txbinfo.ReadOnly = true;
            this.txbinfo.Size = new System.Drawing.Size(411, 129);
            this.txbinfo.TabIndex = 3;
            this.txbinfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbinfo.TextChanged += new System.EventHandler(this.txbinfo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "WELCOME TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "ATM TELLER MACHINE APPLICATION!";
            // 
            // btSecret
            // 
            this.btSecret.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSecret.Location = new System.Drawing.Point(534, 371);
            this.btSecret.Name = "btSecret";
            this.btSecret.Size = new System.Drawing.Size(75, 69);
            this.btSecret.TabIndex = 2;
            this.btSecret.Text = "ADM";
            this.btSecret.UseVisualStyleBackColor = false;
            this.btSecret.Click += new System.EventHandler(this.btSecret_Click);
            // 
            // txadmname
            // 
            this.txadmname.BackColor = System.Drawing.Color.Silver;
            this.txadmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txadmname.Location = new System.Drawing.Point(136, 258);
            this.txadmname.Name = "txadmname";
            this.txadmname.Size = new System.Drawing.Size(332, 26);
            this.txadmname.TabIndex = 0;
            this.txadmname.Visible = false;
            // 
            // txbadmPass
            // 
            this.txbadmPass.BackColor = System.Drawing.Color.Silver;
            this.txbadmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbadmPass.Location = new System.Drawing.Point(136, 322);
            this.txbadmPass.Name = "txbadmPass";
            this.txbadmPass.Size = new System.Drawing.Size(332, 26);
            this.txbadmPass.TabIndex = 1;
            this.txbadmPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrator Only";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(138, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "PassWord";
            this.label2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btBackToWork
            // 
            this.btBackToWork.BackColor = System.Drawing.Color.Green;
            this.btBackToWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btBackToWork.Location = new System.Drawing.Point(136, 369);
            this.btBackToWork.Name = "btBackToWork";
            this.btBackToWork.Size = new System.Drawing.Size(331, 42);
            this.btBackToWork.TabIndex = 7;
            this.btBackToWork.Text = "Reactivate System";
            this.btBackToWork.UseVisualStyleBackColor = false;
            this.btBackToWork.Visible = false;
            this.btBackToWork.Click += new System.EventHandler(this.btBackToWork_Click);
            // 
            // FRMOutOfService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(609, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btBackToWork);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbadmPass);
            this.Controls.Add(this.txadmname);
            this.Controls.Add(this.btSecret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbinfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMOutOfService";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorry We are Out Pf Service";
            this.Load += new System.EventHandler(this.FRMOutOfService_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbinfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSecret;
        private System.Windows.Forms.TextBox txadmname;
        private System.Windows.Forms.TextBox txbadmPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btBackToWork;
    }
}