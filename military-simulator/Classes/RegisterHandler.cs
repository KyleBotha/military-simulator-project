using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using military_simulator.Classes;
namespace military_simulator.Classes
{
    class RegisterHandler
    {
        string name;
        string surname; 
        string rank; 
        string dodId; 
        string affiliation; 
        string username; 
        string password; 
        string cPassword;
        public RegisterHandler(string name, string surname, string rank, string dodId, string affiliation, string username, string password, string cPassword)
        {
            this.name = name;
            this.surname  = surname;
            this.rank = rank;
            this.dodId = dodId;
            this.affiliation = affiliation;
            this.username = username;
            this.password = password;
            this.cPassword = cPassword;
            register(); 
        }
        private static string hashedandsaltedpwd;
        public void register()
        {
            checkFieldsEmpty();
            passwordMatch();
            SQLHandler database = new SQLHandler();
            Encryption enc = new Encryption();
            string salt = enc.createSalt();
            hashedandsaltedpwd = enc.MD5(password + salt);
            database.createUser(this.name, this.surname, this.rank, this.dodId, this.affiliation, this.username, hashedandsaltedpwd, salt);
        }
        public bool passwordMatch()
        {
            if (this.password == this.cPassword)
            {
                return true;
            }else
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
        }
        public bool checkFieldsEmpty()
        {
            if (String.IsNullOrEmpty(this.name))
            {
                MessageBox.Show("Please do not leave the name field blank.");
                return true;
            }else if (String.IsNullOrEmpty(this.surname))
            {
                MessageBox.Show("Please do not leave the surname field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.rank))
            {
                MessageBox.Show("Please do not leave the rank field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.dodId))
            {
                MessageBox.Show("Please do not leave the dodId field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.affiliation))
            {
                MessageBox.Show("Please do not leave the affiliation field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.username))
            {
                MessageBox.Show("Please do not leave the username field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.password))
            {
                MessageBox.Show("Please do not leave the password field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.cPassword))
            {
                MessageBox.Show("Please do not leave the confirm password field blank.");
                return true;
            }
            return false;
        }
    }
}
