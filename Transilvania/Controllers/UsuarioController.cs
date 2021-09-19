using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Created("", usuario);
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
        [Route("getid/{id}")]
    
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um usuario por id
            Usuario usuario = _context.Usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound("Usuario não encontrado, catapimbas!");
            }
            return Ok(usuario);
        }

        //GET/api/usuario/delete/xxxx
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