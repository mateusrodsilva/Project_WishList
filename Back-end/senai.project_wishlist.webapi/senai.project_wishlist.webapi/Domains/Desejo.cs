using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.project_wishlist.webapi.Domains
{
    public partial class Desejo
    {
        public int IdDesejo { get; set; }
        public int? IdUsuario { get; set; }
        [Required(ErrorMessage ="A Desceição do desejo é obrigatória")]
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        [Required]
        public bool Prioridade { get; set; }
        [Required]
        public bool Favorito { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
