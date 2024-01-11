using BaseLayer;
using ControlLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layer_3
{
    public partial class Form1 : Form
    {
        Transaction mTransaction = new Transaction();
        Bank mBank  = new Bank();
        public Form1()
        {
            InitializeComponent();
            balText.Text = (mBank.getBalance()).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float amt = float.Parse(depAmt.Text);
            mTransaction.checkDeposit(amt);
            if (!(string.Equals(balText.Text, (mBank.getBalance()).ToString())))
            {
                balText.Text = (mBank.getBalance()).ToString();
                depAmt.Text = "";
            }
            else
                MessageBox.Show( "Amount Can't Be Greater than 100000 ");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float amt = float.Parse(withAmt.Text);
            mTransaction.checkWithdraw(amt);
            if (balText.Text != (mBank.getBalance()).ToString())
            {
                balText.Text = (mBank.getBalance()).ToString();
                withAmt.Text = "";
            }
            else
                MessageBox.Show("Minimum balance is to be maintained");
        }
    }
}
