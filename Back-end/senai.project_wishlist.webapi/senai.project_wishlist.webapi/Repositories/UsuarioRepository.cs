using senai.wishlist.webApi.Contexts;
using senai.wishlist.webApi.Domains;
using senai.wishlist.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.wishlist.webApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ProjectWishListContext ctx = new ProjectWishListContext();
        public void Atualizar(int id, Usuario UsuarioAtt)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(id);

            if (UsuarioAtt.NomeUsuario != null && UsuarioAtt.Email != null && UsuarioAtt.Senha != null && UsuarioAtt.Foto != null)
            {
                UsuarioBuscado.NomeUsuario = UsuarioAtt.NomeUsuario;
                UsuarioBuscado.Email = UsuarioAtt.Email;
                UsuarioBuscado.Senha = UsuarioAtt.Senha;
                UsuarioBuscado.Foto = UsuarioAtt.Foto;
            }

            ctx.Usuarios.Update(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(t => t.IdUsuario == id); ;
        }

        public void Cadastrar(Usuario NovoUsuario)
        {
            ctx.Usuarios.Add(NovoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario UsuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(UsuarioBuscado);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(l => l.Email == email && l.Senha == senha);
        }
    }
}
