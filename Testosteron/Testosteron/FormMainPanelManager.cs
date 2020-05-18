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
    public partial class FormMainPanelManager : Form
    {
        private Login2 fx;

        public FormMainPanelManager(Login2 fl)
        {
            fx = fl;
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient f = new FormAddClient();
            f.ShowDialog();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder f = new FormAddOrder();
            f.ShowDialog();
        }

     

        private void buttonCheckState_Click(object sender, EventArgs e)
        {
            FormCheckState f = new FormCheckState();
            f.ShowDialog();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            FormAddSupplier f = new FormAddSupplier();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddProduct f = new FormAddProduct();
            f.ShowDialog();
        }

        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            FormAddSupply f = new FormAddSupply();
            f.ShowDialog();
        }

      

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            fx.Show();
            this.Close();
        }
    }
}
