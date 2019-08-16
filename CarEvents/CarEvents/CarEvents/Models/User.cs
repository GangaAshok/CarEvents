using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents.Models
{
    class User
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool checkInformation()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
