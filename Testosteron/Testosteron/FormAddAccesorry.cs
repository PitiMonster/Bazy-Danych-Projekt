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
    public partial class FormAddAccesorry : Form
    {
        public FormAddAccesorry()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string type = checkedListBoxProtein.SelectedItem.ToString();
            string name = textBoxName.Text;
            string desc = richTextBoxDescription.Text;
            int price = Convert.ToInt32(textBoxPrice.Text);
            int amount = Convert.ToInt32(textBoxAmount.Text);
            if (price <= 0 || amount <= 0)
            {
                MessageBox.Show("Ujemne liczby! NIEŁADNIE");
            }
            else
            {
                LoginForm.db.dodaj_akcesoria(type, name, desc, price, amount);
                MessageBox.Show("dodano akcesoria!");
                this.Close();
            }
        }
    }
}
