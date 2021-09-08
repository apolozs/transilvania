using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/Quarto")]
    public class QuartoController : ControllerBase

    {
        
        private readonly DataContext _context;

        //Construtor
        public QuartoController(DataContext context) => _context = context;

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Quarto quarto)
        {

            _context.Quartos.Add(quarto);
            _context.SaveChanges();
            return Created("", quarto);
        }

        [HttpGet]
        [Route("list")]
        public List<Quarto> list() => _context.Quartos.ToList();
        
        
        [HttpGet]
        [Route("getid/{id}")]
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um hotel por id
            Quarto quarto = _context.Quartos.Find(id);
            if (quarto == null)
            {
                return NotFound("hotel não encontrado, catapimbas!");
            }
            return Ok(quarto);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete([FromRoute] int id)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Quarto quarto = _context.Quartos.Find(id);
            if (quarto == null)
            {
                return NotFound();
            }
            _context.Quartos.Remove(quarto);
            _context.SaveChanges();
            return Ok(_context.Quartos.ToList());
        }
    }
}