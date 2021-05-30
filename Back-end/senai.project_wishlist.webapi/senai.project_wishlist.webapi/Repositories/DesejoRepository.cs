using senai.project_wishlist.webapi.Contexts;
using senai.project_wishlist.webapi.Domains;
using senai.wishlist.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.wishlist.webApi.Repositories
{
    public class DesejoRepository : IDesejoRepository
    {
        WishListContext ctx = new WishListContext();

        public void Atualizar(int id, Desejo DesejoAtt)
        {
            Desejo DesejoBuscado = ctx.Desejos.Find(id);

            if (DesejoAtt.Descricao != null && DesejoAtt.DataCriacao == DateTime.UtcNow && (DesejoAtt.Prioridade == true || DesejoAtt.Prioridade == false) && (DesejoAtt.Favorito == true || DesejoAtt.Favorito == false))
            {
                DesejoBuscado.Descricao = DesejoAtt.Descricao;
                DesejoBuscado.DataCriacao = DesejoAtt.DataCriacao;
                DesejoBuscado.Prioridade = DesejoAtt.Prioridade;
                DesejoBuscado.Favorito = DesejoAtt.Favorito;
            }

            ctx.Desejos.Update(DesejoBuscado);
            ctx.SaveChanges();
        }

        public Desejo BuscarPorId(int id)
        {
            return ctx.Desejos.FirstOrDefault(t => t.IdDesejo == id);
        }

        public void Cadastrar(Desejo NovoDesejo)
        {
            ctx.Desejos.Add(NovoDesejo);
            ctx.SaveChanges(); ;
        }

        public void Deletar(int id)
        {
            Desejo DesejoBuscado = ctx.Desejos.Find(id);

            ctx.Desejos.Remove(DesejoBuscado);
            ctx.SaveChanges();
        }

        public List<Desejo> Listar()
        {
            return ctx.Desejos.ToList();
        }
    }
}
