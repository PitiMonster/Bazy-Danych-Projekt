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
    public partial class FormMainPanelAdmin : Form
    {
        private Login2 fx;

        public FormMainPanelAdmin(Login2 fl)
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


        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser f = new FormAddUser();
            f.ShowDialog();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            FormDeleteUser f = new FormDeleteUser();
            f.ShowDialog();
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            LoginForm.db.Backup();
            MessageBox.Show("Zapisano backup pomyślnie!");
            
        }

        private void buttonResore_Click(object sender, EventArgs e)
        {
            LoginForm.db.Restore();
            MessageBox.Show("Wczytano backup pomyślnie!");

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            fx.Show();
            this.Close();
        }
    }
}
