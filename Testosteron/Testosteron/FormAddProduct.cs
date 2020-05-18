using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testosteron
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void buttonAddWPC_Click(object sender, EventArgs e)
        {
            FormAddWPC f = new FormAddWPC();
            f.ShowDialog();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddSuplement_Click(object sender, EventArgs e)
        {
            FormAddSuplement f = new FormAddSuplement();
            f.ShowDialog();
        }

        private void buttonAddOther_Click(object sender, EventArgs e)
        {
            FormAddOdżywka f = new FormAddOdżywka();
            f.ShowDialog();
        }

        private void buttonAddAccessory_Click(object sender, EventArgs e)
        {
            FormAddAccesorry f = new FormAddAccesorry();
            f.ShowDialog();
        }
    }
}
