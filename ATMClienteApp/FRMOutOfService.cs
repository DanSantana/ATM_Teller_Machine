using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMclassLibrary;
using System.Threading;


namespace ATMClienteApp
{
    public partial class FRMOutOfService : Form
    {
        atmManager atm;
        FrmLogin mylog;
        public FRMOutOfService(atmManager ATM, FrmLogin MYLOG)
        {
            InitializeComponent();
            atm = ATM;
            mylog = MYLOG;
        }
        private void FRMOutOfService_Load(object sender, EventArgs e)
        {
            txbinfo.Text = "    ** Temporarily out Of Service. **" + Environment.NewLine + " ** sorry for the inconvenience! **";
        }
        private void txbinfo_TextChanged(object sender, EventArgs e)
        {
        }
        private void btSecret_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            txadmname.Visible = true;
            txbadmPass.Visible = true;
            btBackToWork.Visible = true;

            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick_1);
            txadmname.Clear();
            txbadmPass.Clear();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            txadmname.Visible = false;
            txbadmPass.Visible = false;
            btBackToWork.Visible = false;
            txbinfo.Clear();
            txbinfo.Text = "    ** Temporarily out Of Service. **" + Environment.NewLine + " ** sorry for the inconvenience! **";
        }
        private void btBackToWork_Click(object sender, EventArgs e)
        {
            if (txadmname.Text == "Korben Dallas" && txbadmPass.Text == "D001")
            {
                this.Close();
                mylog.Show();
            }
            else if(txadmname.Text == null || txbadmPass.Text==null)
            {
                txbinfo.Clear();
                txbinfo.Text = "WARNING!!"+Environment.NewLine + Environment.NewLine + " ** This Field is Reserved to Administrator Only **";
                txadmname.Clear();
                txbadmPass.Clear();
                timer1.Stop();
                timer1.Enabled = true;
                timer1.Interval = 3000;
                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick_1);
            }
            else
            {
                txbinfo.Clear();
                txbinfo.Text = "    ** WARNING!!**" + Environment.NewLine + " ** This Field is Reserved to Administrator Only **";
                txadmname.Clear();
                txbadmPass.Clear();
                timer1.Stop();
                timer1.Enabled = true;
                timer1.Interval = 3000;
                timer1.Start();
                timer1.Tick += new EventHandler(timer1_Tick_1);
                btBackToWork.Visible = false;
            }
        }
    }
}
