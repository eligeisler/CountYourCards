using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountYourCards.Models {
     public class Spielstand {
        public int SpielstandId { get; set; }
        public int Team1 { get; set; }
        public int Team2 { get; set; }
        public User User { get; set; }
        


    }
}
