using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/historico")]
    public class HistoricoController : ControllerBase
    
    {

        private readonly DataContext _context;

        //Construtor
        public HistoricoController(DataContext context) => _context = context;

        //POST /api/historico/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Historico historico)
        {
            _context.Historicos.Add(historico);
            _context.SaveChanges();
            return Created("", historico);
        }
 


        //GET /api/historico/list
        [HttpGet]
        [Route("list")]
        public List<Historico> list() 
        {
             return _context.Historicos.ToList();
            //  Courses
            //     .Include(i => i.Modules.Select(s => s.Chapters)).Include(i => i.Lab)
        }


        //GET/api/historico/getid/id
        [HttpGet]
        [Route("getid/{id}")]
    
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um historico por id
            Historico historico = _context.Historicos.Find(id);
            if (historico == null)
            {
                return NotFound("Historico não encontrado, catapimbas!");
            }
            return Ok(historico);
        }

        //GET/api/historico/delete/xxxx
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult delete([FromRoute] int id)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Historico historicos = _context.Historicos.Find(id);
            if (historicos == null)
            {
                return NotFound();
            }
            _context.Historicos.Remove(historicos);
            _context.SaveChanges();
            return Ok(_context.Historicos.ToList());
        }
        
    }

}