using MySql.Data.MySqlClient;
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
    public partial class FormAddSupply : Form
    {
        private string login;

        public FormAddSupply()
        {
            InitializeComponent();

            MySqlCommand cmd = LoginForm.db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM produkty";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridViewAll.DataSource = DS.Tables[0];
            cmd.CommandText = "SELECT * FROM dostawcy";
            mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;

            DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            string all ="";
            string dodaj;
            foreach (DataGridViewRow r in dataGridViewProducts.Rows)
            {
                var x = r.Cells[0].Value;
                var y = r.Cells[1].Value;
                if (x != null && y != null)
                {
                    dodaj = x + "," + y + ";";
                    all += dodaj;
                }
            }
            Console.Write(all + "\n\n\n\n");
            int a = Convert.ToInt32(textBoxNIP.Text);
            if (all !="" && textBoxNIP.Text != null && LoginForm.db.addSupply(dateTimePickerDate.Value, all,a ))
            {
                MessageBox.Show("Dodano dostawę!");
                this.Close();
            }
            else MessageBox.Show("Nie dodano dostawy!");
        }
    }
}
