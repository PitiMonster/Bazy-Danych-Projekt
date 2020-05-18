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
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (LoginForm.db.addUser(textBoxLogin.Text, textBoxPassword.Text, textBoxType.Text))
            {
                MessageBox.Show("dodano użytkownika!");
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                textBoxType.Clear();
            }
            else
            {
                MessageBox.Show("już jest taki user!");
                textBoxLogin.Clear();
                textBoxPassword.Clear();
                textBoxType.Clear();
            }
        }
    }
}
