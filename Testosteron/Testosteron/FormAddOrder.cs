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
    public partial class FormAddOrder : Form
        //TODO: Transakcje - przycisk DODAJ
    {
        public FormAddOrder()
        {

            InitializeComponent();
            MySqlCommand cmd = LoginForm.db.connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM produkty";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridViewAll.DataSource = DS.Tables[0];
            cmd.CommandText = "SELECT * FROM klienci";
            mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;

            DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void dataGridViewProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //TODO: database -> dataGridAll
            //TODO: doubleClick na dataGridAll -> dodanie produktu do dataGridViewProducts -> dodanie produktu do bazy danych
            //TODO: usunięcie z dataGridViewProducts -> usunięcie z bazy danych
            Console.WriteLine(dataGridViewProducts.SelectedRows[0].Cells[0].Value);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            string all = "";
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
            if (all != "" && textBoxNIP.Text != null && LoginForm.db.addOrder(dateTimePickerDate.Value, all, Convert.ToInt32(textBoxNIP.Text)))
            {
                MessageBox.Show("Dodano nowe zamówienie!");
                this.Close();
            }
            else MessageBox.Show("Nie dodano zamówienia!");
        }
    }
}
