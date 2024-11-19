using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Johan_Modul7
{
    internal class Employee
    {
        private int _empID;
        private string _loginName;
        private string _password;
        // private int _securityLevel;

        public int EmployeeID
        {
            get { return _empID; }
            set { _empID = value; }
        }

        public string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        /* public int SecurityLevel
        {
            get { return _securityLevel; }
        } */

        // Definisikan Method Kelas
        /*public Boolean Login(string loginName, string password)
        {
            if (LoginName == "Jono" & password == "wkwk")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (LoginName == "Jones" & password == "haha")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }*/

        public Employee() { }

        public Employee(string loginName, string password)
        {
            LoginName = loginName;
            Password = password;
        }

        public bool Login()
        {
            if (LoginName == "Jono" && Password == "wkwk")
            {
                EmployeeID = 1;
                return true;
            }
            else if (LoginName == "Jones" && Password == "haha")
            {
                EmployeeID = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

