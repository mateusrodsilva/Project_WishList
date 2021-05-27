using senai.project_wishlist.webapi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.wishlist.webApi.Interfaces
{
    interface IDesejoRepository
    {
        /// <summary>
        /// Método que cadastra um novo Desejo
        /// </summary>
        /// <param name="NovoDesejo">Objeto novo Desejo que contém as informações do novo desejo</param>
        public void Cadastrar(Desejo NovoDesejo);

        /// <summary>
        /// Lista todos os desejos
        /// </summary>
        /// <returns>Lista com os desejos</returns>
        List<Desejo> Listar();

        /// <summary>
        /// Busca um desejo pelo id 
        /// </summary>
        /// <param name="id">id do desejo que será buscado</param>
        /// <returns>Desejo buscado</returns>
        Desejo BuscarPorId(int id);

        /// <summary>
        /// Atualiza um desejo pelo Id
        /// </summary>
        /// <param name="id">Id do desejo que será atualizado</param>
        /// <param name="DesejoAtt">Objeto DesejoAtt com as informações atualizadas</param>
        void Atualizar(int id, Desejo DesejoAtt);

        /// <summary>
        /// Deleta um desejo existente
        /// </summary>
        /// <param name="id">Id do desejo que será deletado</param>
        void Deletar(int id);

    }
}
