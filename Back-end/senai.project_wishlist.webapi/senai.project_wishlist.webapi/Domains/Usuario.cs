using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.project_wishlist.webapi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Desejos = new HashSet<Desejo>();
        }

        public int IdUsuario { get; set; }
        [Required(ErrorMessage ="Insira seu nome")]
        public string NomeUsuario { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public string Foto { get; set; }

        public virtual ICollection<Desejo> Desejos { get; set; }
    }
}
