using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Transilvania.Controllers

{
    [ApiController]
    [Route("api/Adicionais")]
    public class AdicionaisController : ControllerBase

    {
        
        private readonly DataContext _context;

        //Construtor
        public AdicionaisController(DataContext context) => _context = context;

        //POST /api/hotel/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Adicionais adicionais)
        {

            _context.Adicionais.Add(adicionais);
            _context.SaveChanges();
            return Created("", adicionais);
        }

        //GET /api/hotel/list
        [HttpGet]
        [Route("list")]

            public List<Adicionais> list() => _context.Adicionais.ToList();
        
                //GET/api/hotel/getid/id
        [HttpGet]
        [Route("getid/{id}")]
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um hotel por id
            Adicionais adicionais = _context.Adicionais.Find(id);
            if (adicionais == null)
            {
                return NotFound("hotel não encontrado, catapimbas!");
            }

            return Ok(adicionais);
        }

        //GET/api/hotel/delete/xxxx
         [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete([FromRoute] int id)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Adicionais adicionais = _context.Adicionais.Find(id);
            if (adicionais == null)
            {
                return NotFound();
            }
            _context.Adicionais.Remove(adicionais);
            _context.SaveChanges();
            return Ok(_context.Adicionais.ToList());
        }
    }
}