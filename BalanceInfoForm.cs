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

        public BalanceInfoForm(Form1 callingForm)
        {
            InitializeComponent();
            fiblette = callingForm;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            fiblette.Show();
        }

    }
}
