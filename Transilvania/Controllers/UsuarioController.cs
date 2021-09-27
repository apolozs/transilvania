using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System;

namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    
    {

        private readonly DataContext _context;

        //Construtor
        public UsuarioController(DataContext context) => _context = context;

        //POST /api/usuario/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario.Nome == null || usuario.Senha == null || usuario.Cpf == null)
                    throw new Exception("Não foi possivel gerar um usuario por falta de dados");
                
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
                return Created("", usuario);
            }
            catch (Exception ex)
            {
                
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message );
           
            }

        }
 


        //GET /api/usuario/list
        [HttpGet]
        [Route("list")]
        public List<Usuario> list() 
        {
            //  return _context.Usuarios.Include(x => x.Quarto).ThenInclude(x => x.Historico).ToList();
            //  Courses
            return _context.Usuarios.ToList();
           
        }


        //GET/api/usuario/getid/id
        [HttpGet]
        [Route("login/{cpf}/{senha}")]
        public IActionResult login([FromRoute] string cpf, string senha)
        {
            //Buscar um usuario por id
            Usuario usuario = _context.Usuarios.First(x => x.Cpf == cpf);
            if (usuario == null)
            {
                return NotFound("Usuario não encontrado, catapimbas!");
            }else if (usuario.Senha == senha)
            {
                return Ok(usuario);
            }
        
            return NotFound("Senha Incorreta!");
        }

        //GET/api/usuario/delete/x
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete([FromRoute] int id)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok(_context.Usuarios.ToList());
        }
        
    }

}