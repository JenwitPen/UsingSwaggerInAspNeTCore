using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWithSwagger.Model
{
    public class User
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string tel { get; set; }
     
        public User(int id, string name, string email, string tel)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.tel = tel;
        }
    }
}
