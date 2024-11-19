using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3
{
    class Employee
    {
        // Definisikan Property
        // Pertama definisikan instance variable
        private int _empID;
        private string _loginName;
        private string _password;
        private int _securityLevel;

        public int EmployeeID
        {
            get { return _empID; }
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

        public int SecurityLevel
        {
            get { return _securityLevel; }
        }

        // Definisikan Method Kelas
        public Boolean Login(string loginName, string password)
        {
            // Data biasanya berasal dari database
            // Pada praktikum ini memakai data dummy dulu
            if (loginName == "Jono" & password == "wkwk")
            {
                _empID = 1;
                _securityLevel = 2;
                return true;
            }
            else if (loginName == "Jones" & password == "haha")
            {
                _empID = 2;
                _securityLevel = 4;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
