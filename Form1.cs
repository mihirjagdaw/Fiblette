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
        private int bankroll = 0;


        public Form1()
        {
            InitializeComponent();
            createFibSequence();
            resetFib();

            lblBalance.Visible = false;
            btnLose.Visible = false;
            btnWin.Visible = false;
        }

        private void createFibSequence()
        {
            fibSequence[0] = 1;
            fibSequence[1] = 1;

            for (int i = 2; i < fibSequence.Length; i++)
            {
                fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2];
            }
        }

        private void resetFib()
        {
            fibIndex = 0;
            lblBalance.Text = $"Balance: {bankroll}";
            lblAmount.Text = $"Bet R {fibSequence[fibIndex].ToString()}";
        }

        private void btnWin_Click(object sender, EventArgs e)
        {
            bankroll += fibSequence[fibIndex] * 3;
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
            lblBalance.Text = $"Balance: {bankroll}";
            lblAmount.Text = $"Bet R {fibSequence[fibIndex].ToString()}";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bankroll = int.Parse(txtStartingAmount.Text);

            lblBalance.Visible = true;
            btnLose.Visible = true;
            btnWin.Visible = true;

            lblStartingAmount.Visible = false;
            txtStartingAmount.Visible = false;
            btnEnter.Visible = false;
        }
    }
}
