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
    public partial class FormListOfProducts : Form
    {
        public string category;
        public int min, max, amount;

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FormListOfProducts(string c, string mmin, string mmax, string am)
        {
            category = c;
            min = Convert.ToInt32(mmin) ;
            max = Convert.ToInt32(mmax);
            amount = Convert.ToInt32(am);
            InitializeComponent();
                MySqlCommand cmd = LoginForm.db.connection.CreateCommand();
            cmd.CommandText = "call selectgwiazda(?typ, ?min, ?max, ?am)";
                cmd.Parameters.AddWithValue("?typ", c);
                cmd.Parameters.AddWithValue("?min", min);
                cmd.Parameters.AddWithValue("?max", max);
                cmd.Parameters.AddWithValue("?am", amount);

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = cmd;
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            
        }
    }
}
