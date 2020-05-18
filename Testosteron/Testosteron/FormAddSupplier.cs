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
    public partial class FormAddSupplier : Form
    {
        //TODO:  dodawanie dostawcy do bazy danych
        //TODO: sprawdzanie NIP
        public FormAddSupplier()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCheckNIP_Click(object sender, EventArgs e)
        {
            long liczba = Convert.ToInt64(textBoxPassword.Text);
            int dlugosc = textBoxPassword.Text.Length;
            if (LoginForm.db.sprawdz_nip(liczba, dlugosc))
            {
                MessageBox.Show("prawidłowy!");
            }
            else MessageBox.Show("Nie jest prawidłowy!");
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            string dostawca = textBoxLogin.Text;
            string adres = textBoxAdres.Text;
            long liczba = Convert.ToInt64(textBoxPassword.Text);
            int dlugosc = textBoxPassword.Text.Length;
            string nip = textBoxPassword.Text;
            if (LoginForm.db.sprawdz_nip(liczba, dlugosc))
            {
                if (LoginForm.db.dodaj_dostawce(dostawca, nip, adres))
                {
                    MessageBox.Show("Dodano dostawcę!");
                    this.Close();
                }
                else MessageBox.Show("Nie dodano dostawcy! BŁĄD!");
            }
            else MessageBox.Show("Zły nip!");
        }
    }
}
