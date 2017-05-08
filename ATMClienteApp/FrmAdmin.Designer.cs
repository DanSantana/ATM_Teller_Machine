namespace ATMClienteApp
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.txbadminInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPayInterest = new System.Windows.Forms.Button();
            this.btRefill = new System.Windows.Forms.Button();
            this.btTakeOutofService = new System.Windows.Forms.Button();
            this.btPrintRport = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btDisplayReport = new System.Windows.Forms.Button();
            this.btTurnOff = new System.Windows.Forms.Button();
            this.btNewOp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txbadminInfo
            // 
            this.txbadminInfo.BackColor = System.Drawing.Color.DarkGray;
            this.txbadminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbadminInfo.Location = new System.Drawing.Point(25, 50);
            this.txbadminInfo.Multiline = true;
            this.txbadminInfo.Name = "txbadminInfo";
            this.txbadminInfo.ReadOnly = true;
            this.txbadminInfo.Size = new System.Drawing.Size(380, 243);
            this.txbadminInfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(105, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "ATM Teller Administrator";
            // 
            // btPayInterest
            // 
            this.btPayInterest.BackColor = System.Drawing.Color.DimGray;
            this.btPayInterest.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPayInterest.Location = new System.Drawing.Point(427, 50);
            this.btPayInterest.Name = "btPayInterest";
            this.btPayInterest.Size = new System.Drawing.Size(170, 50);
            this.btPayInterest.TabIndex = 0;
            this.btPayInterest.Text = "Pay Interest";
            this.btPayInterest.UseVisualStyleBackColor = false;
            this.btPayInterest.Click += new System.EventHandler(this.btPayInterest_Click);
            // 
            // btRefill
            // 
            this.btRefill.BackColor = System.Drawing.Color.DimGray;
            this.btRefill.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefill.Location = new System.Drawing.Point(427, 105);
            this.btRefill.Name = "btRefill";
            this.btRefill.Size = new System.Drawing.Size(170, 50);
            this.btRefill.TabIndex = 1;
            this.btRefill.Text = "Refill $";
            this.btRefill.UseVisualStyleBackColor = false;
            this.btRefill.Click += new System.EventHandler(this.btRefill_Click);
            // 
            // btTakeOutofService
            // 
            this.btTakeOutofService.BackColor = System.Drawing.Color.DimGray;
            this.btTakeOutofService.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTakeOutofService.Location = new System.Drawing.Point(427, 160);
            this.btTakeOutofService.Name = "btTakeOutofService";
            this.btTakeOutofService.Size = new System.Drawing.Size(170, 50);
            this.btTakeOutofService.TabIndex = 2;
            this.btTakeOutofService.Text = "Out Of Service";
            this.btTakeOutofService.UseVisualStyleBackColor = false;
            this.btTakeOutofService.Click += new System.EventHandler(this.btTakeOutofService_Click);
            // 
            // btPrintRport
            // 
            this.btPrintRport.BackColor = System.Drawing.Color.DimGray;
            this.btPrintRport.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPrintRport.Location = new System.Drawing.Point(427, 215);
            this.btPrintRport.Name = "btPrintRport";
            this.btPrintRport.Size = new System.Drawing.Size(170, 50);
            this.btPrintRport.TabIndex = 3;
            this.btPrintRport.Text = "Print Report";
            this.btPrintRport.UseVisualStyleBackColor = false;
            this.btPrintRport.Click += new System.EventHandler(this.btPrintRport_Click);
            // 
            // btQuit
            // 
            this.btQuit.BackColor = System.Drawing.Color.DimGray;
            this.btQuit.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuit.Location = new System.Drawing.Point(427, 380);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(170, 50);
            this.btQuit.TabIndex = 6;
            this.btQuit.Text = "Quit";
            this.btQuit.UseVisualStyleBackColor = false;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox2.Location = new System.Drawing.Point(25, 299);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(380, 135);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // btDisplayReport
            // 
            this.btDisplayReport.BackColor = System.Drawing.Color.DimGray;
            this.btDisplayReport.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplayReport.Location = new System.Drawing.Point(427, 270);
            this.btDisplayReport.Name = "btDisplayReport";
            this.btDisplayReport.Size = new System.Drawing.Size(170, 50);
            this.btDisplayReport.TabIndex = 4;
            this.btDisplayReport.Text = "Display Report";
            this.btDisplayReport.UseVisualStyleBackColor = false;
            this.btDisplayReport.Click += new System.EventHandler(this.btDisplayReport_Click);
            // 
            // btTurnOff
            // 
            this.btTurnOff.BackColor = System.Drawing.Color.DimGray;
            this.btTurnOff.Font = new System.Drawing.Font("Verdana", 13.25F);
            this.btTurnOff.Location = new System.Drawing.Point(427, 325);
            this.btTurnOff.Name = "btTurnOff";
            this.btTurnOff.Size = new System.Drawing.Size(170, 50);
            this.btTurnOff.TabIndex = 5;
            this.btTurnOff.Text = "Turn Off System";
            this.btTurnOff.UseVisualStyleBackColor = false;
            this.btTurnOff.Click += new System.EventHandler(this.btTurnOff_Click);
            // 
            // btNewOp
            // 
            this.btNewOp.BackColor = System.Drawing.Color.DimGray;
            this.btNewOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btNewOp.Location = new System.Drawing.Point(427, 50);
            this.btNewOp.Name = "btNewOp";
            this.btNewOp.Size = new System.Drawing.Size(170, 48);
            this.btNewOp.TabIndex = 10;
            this.btNewOp.Text = "New Operation";
            this.btNewOp.UseVisualStyleBackColor = false;
            this.btNewOp.Click += new System.EventHandler(this.btNewOp_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(609, 441);
            this.ControlBox = false;
            this.Controls.Add(this.btNewOp);
            this.Controls.Add(this.btTurnOff);
            this.Controls.Add(this.btDisplayReport);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btPrintRport);
            this.Controls.Add(this.btTakeOutofService);
            this.Controls.Add(this.btRefill);
            this.Controls.Add(this.btPayInterest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbadminInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Teller Machine Administrator Form";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbadminInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPayInterest;
        private System.Windows.Forms.Button btRefill;
        private System.Windows.Forms.Button btTakeOutofService;
        private System.Windows.Forms.Button btPrintRport;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btDisplayReport;
        private System.Windows.Forms.Button btTurnOff;
        private System.Windows.Forms.Button btNewOp;
        private System.Windows.Forms.Timer timer1;
    }
}