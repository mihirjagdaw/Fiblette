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
    public partial class BalanceInfoForm : Form
    {
        private Form1 fiblette;

        

        public BalanceInfoForm(Form1 callingForm, int maxLosses, int seshPL, string seshWLs)
        {
            InitializeComponent();
            fiblette = callingForm;

            // Set the labels with the provided values
            lblMaxLStreak.Text = maxLosses.ToString();
            lblPL.Text = seshPL.ToString();
            lblWL.Text = seshWLs;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            fiblette.Show();
        }

        
    }
}
