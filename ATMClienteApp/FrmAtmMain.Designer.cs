namespace ATMClienteApp
{
    partial class FrmAtmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtmMain));
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdrawal = new System.Windows.Forms.Button();
            this.btTranfFunds = new System.Windows.Forms.Button();
            this.btPayBill = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAccountinfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCloseApp = new System.Windows.Forms.Button();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.rdbtFromChecking = new System.Windows.Forms.RadioButton();
            this.rdbtFromSaving = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bgaccountSet = new System.Windows.Forms.GroupBox();
            this.bgAmount = new System.Windows.Forms.GroupBox();
            this.btNewTransaction = new System.Windows.Forms.Button();
            this.bgaccountSet.SuspendLayout();
            this.bgAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDeposit
            // 
            this.btDeposit.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btDeposit, "btDeposit");
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.UseVisualStyleBackColor = false;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdrawal
            // 
            this.btWithdrawal.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btWithdrawal, "btWithdrawal");
            this.btWithdrawal.Name = "btWithdrawal";
            this.btWithdrawal.UseVisualStyleBackColor = false;
            this.btWithdrawal.Click += new System.EventHandler(this.btWithdrawal_Click_1);
            // 
            // btTranfFunds
            // 
            this.btTranfFunds.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btTranfFunds, "btTranfFunds");
            this.btTranfFunds.Name = "btTranfFunds";
            this.btTranfFunds.UseVisualStyleBackColor = false;
            this.btTranfFunds.Click += new System.EventHandler(this.btTranfFunds_Click);
            // 
            // btPayBill
            // 
            this.btPayBill.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btPayBill, "btPayBill");
            this.btPayBill.Name = "btPayBill";
            this.btPayBill.UseVisualStyleBackColor = false;
            this.btPayBill.Click += new System.EventHandler(this.btPayBill_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txbAccountinfo
            // 
            this.txbAccountinfo.BackColor = System.Drawing.Color.DarkGray;
            resources.ApplyResources(this.txbAccountinfo, "txbAccountinfo");
            this.txbAccountinfo.Name = "txbAccountinfo";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btCloseApp
            // 
            this.btCloseApp.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btCloseApp, "btCloseApp");
            this.btCloseApp.Name = "btCloseApp";
            this.btCloseApp.UseVisualStyleBackColor = false;
            this.btCloseApp.Click += new System.EventHandler(this.btCloseApp_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.BackColor = System.Drawing.Color.Silver;
            this.txbAmount.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.txbAmount, "txbAmount");
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Click += new System.EventHandler(this.txbAmount_Click);
            this.txbAmount.TextChanged += new System.EventHandler(this.txbAmount_TextChanged);
            this.txbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAmount_KeyPress);
            this.txbAmount.ImeModeChanged += new System.EventHandler(this.txbAmount_ImeModeChanged);
            // 
            // rdbtFromChecking
            // 
            resources.ApplyResources(this.rdbtFromChecking, "rdbtFromChecking");
            this.rdbtFromChecking.Name = "rdbtFromChecking";
            this.rdbtFromChecking.TabStop = true;
            this.rdbtFromChecking.UseVisualStyleBackColor = true;
            // 
            // rdbtFromSaving
            // 
            resources.ApplyResources(this.rdbtFromSaving, "rdbtFromSaving");
            this.rdbtFromSaving.Name = "rdbtFromSaving";
            this.rdbtFromSaving.TabStop = true;
            this.rdbtFromSaving.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // bgaccountSet
            // 
            this.bgaccountSet.Controls.Add(this.rdbtFromSaving);
            this.bgaccountSet.Controls.Add(this.rdbtFromChecking);
            resources.ApplyResources(this.bgaccountSet, "bgaccountSet");
            this.bgaccountSet.Name = "bgaccountSet";
            this.bgaccountSet.TabStop = false;
            // 
            // bgAmount
            // 
            this.bgAmount.Controls.Add(this.label3);
            this.bgAmount.Controls.Add(this.txbAmount);
            resources.ApplyResources(this.bgAmount, "bgAmount");
            this.bgAmount.Name = "bgAmount";
            this.bgAmount.TabStop = false;
            // 
            // btNewTransaction
            // 
            this.btNewTransaction.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.btNewTransaction, "btNewTransaction");
            this.btNewTransaction.Name = "btNewTransaction";
            this.btNewTransaction.UseVisualStyleBackColor = false;
            this.btNewTransaction.Click += new System.EventHandler(this.btNewTransaction_Click_1);
            // 
            // FrmAtmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ControlBox = false;
            this.Controls.Add(this.btNewTransaction);
            this.Controls.Add(this.bgAmount);
            this.Controls.Add(this.bgaccountSet);
            this.Controls.Add(this.btCloseApp);
            this.Controls.Add(this.txbAccountinfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPayBill);
            this.Controls.Add(this.btTranfFunds);
            this.Controls.Add(this.btWithdrawal);
            this.Controls.Add(this.btDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAtmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.FrmAtmMain_Load);
            this.bgaccountSet.ResumeLayout(false);
            this.bgaccountSet.PerformLayout();
            this.bgAmount.ResumeLayout(false);
            this.bgAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdrawal;
        private System.Windows.Forms.Button btTranfFunds;
        private System.Windows.Forms.Button btPayBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAccountinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCloseApp;
        private System.Windows.Forms.TextBox txbAmount;
        private System.Windows.Forms.RadioButton rdbtFromChecking;
        private System.Windows.Forms.RadioButton rdbtFromSaving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox bgaccountSet;
        private System.Windows.Forms.GroupBox bgAmount;
        private System.Windows.Forms.Button btNewTransaction;
    }
}