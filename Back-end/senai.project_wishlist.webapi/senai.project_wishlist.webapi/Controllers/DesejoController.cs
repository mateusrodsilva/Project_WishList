using Microsoft.AspNetCore.Mvc;
using senai.project_wishlist.webapi.Domains;
using senai.wishlist.webApi.Interfaces;
using senai.wishlist.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.project_wishlist.webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DesejoController : ControllerBase
    {
        private IDesejoRepository _desejoRepository { get; set; }
        public DesejoController()
        {
            _desejoRepository = new DesejoRepository();
        }

        /// <summary>
        /// Lista todos os desejos
        /// </summary>
        /// <returns>Lista com os desejos</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_desejoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_desejoRepository.BuscarPorId(id));
        }
        [HttpPost]
        public IActionResult Post(Desejo novoDesejo)
        {
            _desejoRepository.Cadastrar(novoDesejo);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Desejo DesejoAtt)
        {
            _desejoRepository.Atualizar(id, DesejoAtt);

            return StatusCode(204);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _desejoRepository.Deletar(id);
            return StatusCode(204);
        }

    }
}
