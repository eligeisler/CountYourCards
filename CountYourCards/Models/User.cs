using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.Models
{
    public class User {
        public List<Spielstand> Spielstände = new List<Spielstand>();
        public int UserId { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public User(string name, string password) {
            this.Name = name;
            this.Password = password;
           

        }

        public User() : this("unknown", "") { }

    }

}

