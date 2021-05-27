using senai.wishlist.webApi.Contexts;
using senai.wishlist.webApi.Domains;
using senai.wishlist.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.wishlist.webApi.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        ProjectWishListContext ctx = new ProjectWishListContext();

        public void Atualizar(int id, Desejo DesejoAtt)
        {
            Desejo DesejoBuscado = ctx.Desejos.Find(id);

            if (DesejoAtt.Descricao != null && DesejoAtt.de != null && DesejoAtt.Email != null && DesejoAtt.Senha != null)
            {
                DesejoBuscado.IdTipoUsuario = UsuarioAtt.IdTipoUsuario;
                DesejoBuscado.NomeUsuario = UsuarioAtt.NomeUsuario;
                DesejoBuscado.Email = UsuarioAtt.Email;
                DesejoBuscado.Senha = UsuarioAtt.Senha;
            }

            ctx.Usuarios.Update(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public Desejo BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Desejo NovoDesejo)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Desejo> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
