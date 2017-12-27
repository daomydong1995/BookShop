using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Model
{
    [Table("ADMIN")]
   public class ADMIN
    {

        [Key]
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fullname { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public int isAdmin { get; set; }
        public int allowed { get; set; }

    }
}
