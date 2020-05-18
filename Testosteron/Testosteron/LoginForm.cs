using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Testosteron
{
    public partial class LoginForm : Form
    {
        private string login, password;
        private Position pos;
        public static Database db;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
          
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;
            db = new Database(login, password);
            if (!db.OpenConnection())
            {
                MessageBox.Show("Niepoprawne dane logowania");
            }
            else
            {
                if (login == "admin")
                {
                    pos = Position.admin;
                }
                else if (login == "menadżer") pos = Position.manager;
                else pos = Position.worker;
                Login2 f = new Login2(pos, this);
                f.Show();
                this.Hide();

                ///TODO: sprawdzenie logowania, nowa forma pobiera enum 
            }

        }
    }
}
