using System;
using System.Collections.Generic;

#nullable disable

namespace senai.project_wishlist.webapi.Domains
{
    public partial class Desejo
    {
        public int IdDesejo { get; set; }
        public int? IdUsuario { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Prioridade { get; set; }
        public bool Favorito { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
