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
    public partial class Login2 : Form
    {
        private string login, password;
        public Position pos;
        private LoginForm f;
        public Login2(Position p, LoginForm f)
        {
            this.f = f;
            pos = p;
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm.db.closeConnection();
            f.Show();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;
            Console.Write(pos.ToString());
            Console.Write(login + " " + password + "XDDDDDDDDD\n\n\n\n\n\n\n\n\n");

            if (pos == Position.manager)
            {
                if (LoginForm.db.loginUser("menedżer",login,password))
                {
                    FormMainPanelManager f = new FormMainPanelManager(this);
                    f.Show();
                    this.Hide();
                }
                else MessageBox.Show("Niepoprawne dane logowania");


            }
            else if (pos == Position.worker)
            {
                if (LoginForm.db.loginUser("pracownik",login,password))
                {
                    FormMainPanelWorker f = new FormMainPanelWorker(this);
                    f.Show();
                    this.Hide();
                }
                else MessageBox.Show("Niepoprawne dane logowania");

            }
            else
            {
                if (LoginForm.db.loginUser("admin",login,password))
                {
                    FormMainPanelAdmin f = new FormMainPanelAdmin(this);
                    f.Show();
                    this.Hide();
                }
                else MessageBox.Show("Niepoprawne dane logowania");

            }
        }
    }
}
