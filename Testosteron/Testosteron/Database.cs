using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Testosteron
{
    public class Database
    {
        private string login, password, server="localhost", database="testosteronDB";
        public MySqlConnection connection;
        private string connectionString;

        public Database(string login, string password)
        {
            this.login = login;
            this.password = password;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + login + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public string getLogin()
        {
            return login;
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public bool loginUser(string pos, string log, string passw)
        {
            if (pos == null || log == null || passw == null) return false;
            try
            {
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "call logowanie(?login,?haslo);";
                cmd.Parameters.AddWithValue("?login", log);
                cmd.Parameters.AddWithValue("?haslo", passw);
                int retval =  (Int32)cmd.ExecuteScalar();
                if (retval == 2) return false;
                login = log;
                password = passw;
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + " has occurred: " + ex.Message);
                return false;
            }

        }
        public void closeConnection()
        {
            connection.Close();

        }
        public bool addUser(string id, string pass, string typ)
        {
            if (id == null || pass == null || typ == null) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call rejestracja(?login,?haslo, ?typ);";
            cmd.Parameters.AddWithValue("?login", id);
            cmd.Parameters.AddWithValue("?haslo", pass);
            cmd.Parameters.AddWithValue("?typ", typ);
            int var = (Int32)cmd.ExecuteScalar();
            Console.Write(var + "\n\n\n\n\n\n\n\n\n\n\n\n");
            if (var == 0) return true;
            return false;
        }
        public void deleteUser(string login)
        {
            if (login == null) return;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call usuńużytkownika(?login);";
            cmd.Parameters.AddWithValue("?login", login);
            cmd.ExecuteNonQuery();
        }
        
        public void dodaj_bialko(string type, string name, string desc, int price, int amount)
        {
            if (type == null || name == null || desc == null || price <= 0 || amount <= 0)
            {
                return;
            }
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajbiałko(?typ, ?smak, ?opis, ?cena, ?ilosc)";
            cmd.Parameters.AddWithValue("?typ", type);
            cmd.Parameters.AddWithValue("?smak", name);
            cmd.Parameters.AddWithValue("?opis", desc);
            cmd.Parameters.AddWithValue("?cena", price);
            cmd.Parameters.AddWithValue("?ilosc", amount);
            cmd.ExecuteNonQuery();


        }
        public void dodaj_suplement(string type, string name, string desc, int price, int amount)
        {
            MySqlCommand cmd = connection.CreateCommand();
            if(type==null || name==null || desc == null || price <=0 || amount <=0)
            {
                return;
            }
            cmd.CommandText = "call dodajsuplementy(?typ, ?smak, ?opis, ?cena, ?ilosc)";
            cmd.Parameters.AddWithValue("?typ", type);
            cmd.Parameters.AddWithValue("?smak", name);
            cmd.Parameters.AddWithValue("?opis", desc);
            cmd.Parameters.AddWithValue("?cena", price);
            cmd.Parameters.AddWithValue("?ilosc", amount);
            cmd.ExecuteNonQuery();

        }
        public void dodaj_odzywke(string type, string name, string desc, int price, int amount)
        {
            MySqlCommand cmd = connection.CreateCommand();
            if (type == null || name == null || desc == null || price <= 0 || amount <= 0)
            {
                return;
            }
            cmd.CommandText = "call dodajodżywki(?typ, ?smak, ?opis, ?cena, ?ilosc)";
            cmd.Parameters.AddWithValue("?typ", type);
            cmd.Parameters.AddWithValue("?smak", name);
            cmd.Parameters.AddWithValue("?opis", desc);
            cmd.Parameters.AddWithValue("?cena", price);
            cmd.Parameters.AddWithValue("?ilosc", amount);
            cmd.ExecuteNonQuery();

        }
        public void dodaj_akcesoria(string type, string name, string desc, int price, int amount)
        {
            if (type == null || name == null || desc == null || price <= 0 || amount <= 0)
            {
                return;
            }
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajakcesoria(?typ, ?smak, ?opis, ?cena, ?ilosc)";
            cmd.Parameters.AddWithValue("?typ", type);
            cmd.Parameters.AddWithValue("?smak", name);
            cmd.Parameters.AddWithValue("?opis", desc);
            cmd.Parameters.AddWithValue("?cena", price);
            cmd.Parameters.AddWithValue("?ilosc", amount);
            cmd.ExecuteNonQuery();
        }
        public bool sprawdz_nip(long nip, int dlugosc)
        {
            if (dlugosc != 10 && dlugosc!=11) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT validatenip(?a, ?b);";
            cmd.Parameters.AddWithValue("?a", nip);
            cmd.Parameters.AddWithValue("?b", dlugosc);
            bool test = (Boolean)cmd.ExecuteScalar();
            if (test) return true;
            return false;
        }
        public bool dodaj_dostawce(string nazwa, string nip, string adres)
        {
            if (nazwa == null || nip == null || adres == null) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajdostawcę(?nazwa, ?nip, ?adres);";
            cmd.Parameters.AddWithValue("?nazwa", nazwa);
            cmd.Parameters.AddWithValue("?nip", nip);
            cmd.Parameters.AddWithValue("?adres", adres);
            int test = (Int32)cmd.ExecuteScalar();
            if (test == 1) return true;
            // if (test) return true;
            return false;
        }
        public bool dodaj_klienta(string nazwa, string nip, string adres)
        {
            if (nazwa == null || nip == null || adres == null) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajklienta(?nazwa, ?nip, ?adres);";
            cmd.Parameters.AddWithValue("?nazwa", nazwa);
            cmd.Parameters.AddWithValue("?nip", nip);
            cmd.Parameters.AddWithValue("?adres", adres);
            int test = (Int32)cmd.ExecuteScalar();
            if (test == 1) return true;
            // if (test) return true;
            return false;
        }
        public void Backup()
        {
            string file = "C:\\Users\\piotr\\OneDrive\\Pulpit\\Testosteronbackup2.sql";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = connection;
                        mb.ExportToFile(file);
                    }
                }
        }
        public void Restore()
        {
            string file = "C:\\Users\\piotr\\OneDrive\\Pulpit\\Testosteronbackup2.sql";
            using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = connection;
                        mb.ImportFromFile(file);
                    }
                }
            
        }
        public bool addOrder(DateTime data, string s, int id)
        {
            if (s == null || id <= 0) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajsprzedaż(?data, ?s, ?id);";
            cmd.Parameters.AddWithValue("?data", data);
            cmd.Parameters.AddWithValue("?s", s);
           cmd.Parameters.AddWithValue("?id", id);
            var a = cmd.ExecuteScalar();
            string b = a.ToString();
            Console.Write(b + "\n\n\n\n");

            if(b=="1")return true;
            return false;
        }
        public bool addSupply(DateTime data, string s, int id)
        {
            if (s == null || id <= 0) return false;
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "call dodajdostawę(?data, ?s, ?id);";
            cmd.Parameters.AddWithValue("?data", data);
            cmd.Parameters.AddWithValue("?s", s);
            cmd.Parameters.AddWithValue("?id", id);
            cmd.ExecuteNonQuery();


            return true;
        }
    }
}
