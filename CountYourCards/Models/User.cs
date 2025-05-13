using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.Models
{
    public class User {

        public int UserId { get; set; }
        public string Name { get; set; }

        public string password { get; set; }

        public User(string name, string password) {
            this.Name = name;
            this.password = password;
           

        }

        public User() : this("unknown", "") { }

    }

}

