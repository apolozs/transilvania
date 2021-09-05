using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/endereco")]

    public class EnderecoController : ControllerBase
    
    {

        private readonly DataContext _context;

        //Construtor
        public EnderecoController(DataContext context) => _context = context;

        //POST /api/Endereco/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return Created("", endereco);
        }

        //GET /api/endereco/list
        [HttpGet]
        [Route("list")]

        public List<Endereco> list() => _context.Enderecos.ToList();

        //GET/api/endereco/getid/id
        [HttpGet]
        [Route("getid/{id}")]
    
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um endereco por id
            Endereco endereco = _context.Enderecos.Find(id);
            if (endereco == null)
            {
                return NotFound("Endereco não encontrado, catapimbas!");
            }
            return Ok(endereco);
        }

        //GET/api/endereco/delete/xxxx
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult delete([FromRoute] string name)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Nome == name);
            if (endereco == null)
            {
                return NotFound();
            }
            _context.Enderecos.Remove(endereco);
            _context.SaveChanges();
            return Ok(_context.Enderecos.ToList());
        }
        
    }

}