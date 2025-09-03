using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiblette
{
    public partial class Form1 : Form
    {
        private int fibIndex = 0;
        private int[] fibSequence = new int[100];
        private int startingBet = 0;
        private int startingBalance = 0;
        private int bankroll = 0;
        private bool evenPayout = false;

        public Form1()
        {
            InitializeComponent();

            lblAmount.Visible = false;
            lblBalance.Visible = false;
            btnLose.Visible = false;
            btnWin.Visible = false;
        }

        private void calcPayout(bool win)
        {
            // if the user selects even payout, they get 1:1, else 2:1
            if (evenPayout)
            {
                if (win)
                {
                    bankroll += fibSequence[fibIndex] * 2;
                }
                else
                {
                    bankroll -= fibSequence[fibIndex];
                }
            }
            else
            {
                if (win)
                {
                    bankroll += fibSequence[fibIndex] * 3;
                }
                else
                {
                    bankroll -= fibSequence[fibIndex];
                }
            }
        }

        // make elements 0 and 1 a variable set by user input (their starting bet/minimum bet)
        private void createFibSequence()
        {
            // Create Fibonacci sequence starting with the starting bet
            fibSequence[0] = startingBet;
            fibSequence[1] = fibSequence[0];

            for (int i = 2; i < fibSequence.Length; i++)
            {
                fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
            }
        }

        private void displayAmounts()
        {
            if (bankroll > startingBalance)
            {
                lblBalance.ForeColor = Color.Green;
            } else if (bankroll < startingBalance)
            {
                lblBalance.ForeColor = Color.Red;
            } 
            else
            {
                lblBalance.ForeColor = Color.Black;
            }

            lblBalance.Text = $"Balance: {bankroll}";
            lblAmount.Text = $"Bet R {fibSequence[fibIndex].ToString()}";
        }
        private void resetFib()
        {
            fibIndex = 0;
            displayAmounts();
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            calcPayout(true);
            resetFib();
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            bankroll -= fibSequence[fibIndex];
            fibIndex++;
            if (fibIndex >= fibSequence.Length)
            {
                fibIndex = fibSequence.Length - 1;
            }
            
            displayAmounts();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bankroll = int.Parse(txtStartingAmount.Text);
            startingBalance = bankroll;

            evenPayout = cbxEvenPayout.Checked;

            // validate and set starting bet
            startingBet = int.Parse(txtStartingBet.Text);
            if (startingBet < 2)
            {
                MessageBox.Show("Minimum bet is R2");
                return;
            }

            createFibSequence();
            resetFib();

            lblAmount.Visible = true;
            lblBalance.Visible = true;
            btnLose.Visible = true;
            btnWin.Visible = true;

            lblStartingAmount.Visible = false;
            txtStartingAmount.Visible = false;
            cbxEvenPayout.Visible = false;
            lblStartingBet.Visible = false; 
            txtStartingBet.Visible = false;
            btnEnter.Visible = false;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            BalanceInfoForm balanceInfoForm = new BalanceInfoForm(this);
            balanceInfoForm.Show();
            this.Hide();
        }
    }
}
