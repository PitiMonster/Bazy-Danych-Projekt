using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Testosteron
{
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter("SELECT login,typ FROM użytkownicy", LoginForm.db.connection);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridViewAll.DataSource = DS.Tables[0];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != LoginForm.db.getLogin())
            {
                LoginForm.db.deleteUser(textBoxLogin.Text);
                MessageBox.Show("Usunięto usera " + textBoxLogin.Text);
            }
            else MessageBox.Show("Nie można usunąć swojego konta!");

        }

        private void FormDeleteUser_Load(object sender, EventArgs e)
        {

        }
    }
}
