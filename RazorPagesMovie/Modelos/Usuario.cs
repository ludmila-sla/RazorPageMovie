using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Usuario
    {
       
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Nome { get; set; }


       
        [Required]
        [StringLength(60)]
        public string Email { get; set; }


        [StringLength(50)]
        [Required]
        public string Senha { get; set; }
    }
}

