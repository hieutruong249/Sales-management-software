using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string _username;
        private string _password;
        private string _name;
        private string _Email;
        private string _doB;
        private string _salt;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string DoB { get => _doB; set => _doB = value; }
        public string Salt { get => _salt; set => _salt = value; }
    }
}
