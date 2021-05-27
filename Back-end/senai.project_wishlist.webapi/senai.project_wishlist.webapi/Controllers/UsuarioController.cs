﻿using Microsoft.AspNetCore.Mvc;
using senai.project_wishlist.webapi.Domains;
using senai.wishlist.webApi.Interfaces;
using senai.wishlist.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedicalgroup.webapi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os usuários cadastrados
        /// </summary>
        /// <returns>Status Code Ok e Lista dos usuários cadastrados</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_usuarioRepository.Listar());
        }

        /// <summary>
        /// Busca um usuário pelo Id passado na URL
        /// </summary>
        /// <param name="id">Id do usuário que será buscado</param>
        /// <returns>Usuario Buscado</returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_usuarioRepository.BuscarPorId(id));
        }

        /// <summary>
        /// Cadastra um novo Usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto novoUsuario que contém as informações do usuário que será cadastrado</param>
        /// <returns>Status Code 201</returns>
        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            _usuarioRepository.Cadastrar(novoUsuario);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza um Usuario Existente
        /// </summary>
        /// <param name="id">Id do Usuário que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto usuarioAtualizado com as novas informações do Usuário</param>
        /// <returns>Status Code 204</returns>
        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            _usuarioRepository.Atualizar(id, usuarioAtualizado);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um usuário existente 
        /// </summary>
        /// <param name="id">Id do Usuário que será deletado</param>
        /// <returns>Status Code 204</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);
            return StatusCode(204);
        }
    }
}