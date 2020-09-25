using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace military_simulator.Classes
{
    class LoginHandler
    {
        string username;
        string password;
        public LoginHandler(string username, string password)
        {
            this.username = username;
            this.password = password;
            login();
        }
        public void login()
        {
            if (!checkFieldsEmpty())
            {
                attemptLogin(); 
            }
        }
        public bool checkFieldsEmpty()
        {
            if (String.IsNullOrEmpty(this.username))
            {
                MessageBox.Show("Please do not leave the username field blank.");
                return true;
            }
            else if (String.IsNullOrEmpty(this.password))
            {
                MessageBox.Show("Please do not leave the password field blank.");
                return true;
            }
            return false; 
        }
        public bool attemptLogin()
        {
            SQLHandler database = new SQLHandler();
            DataTable usersData = database.readLogin();
            foreach(DataRow user in usersData.Rows)
            {
                if (user["Username"].ToString() == this.username)
                {
                    string hash = user["Hash"].ToString();                          
                    string salt = user["Salt"].ToString();

                    Encryption enc = new Encryption();

                    string hashedandsaltedpwd = enc.MD5(this.password + salt);
                  
                    if (enc.checkHash(this.password, salt, hashedandsaltedpwd))
                    {
                        //MessageBox.Show("Logged in successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect"); 
                    }

                }
            }
            return false;
        }
    }
}
