using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITP.Models
{
    public class Signup
    {
        public int ID { get; set; }
        [Key][Required]
        public string Email { get; set; }
    }
}
