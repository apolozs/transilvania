using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Exception;
using static System.Exception;
using System.Net;

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

            try
            {
                if(quarto.NomeQuarto == null || quarto.QuantidadeDeCamas == 0 || quarto.TipoDeCamas == null || quarto.ImagemQuarto == null || quarto.Preco == 0)
                    throw new System.Exception("Não foi possivel gerar uma reserva");

                _context.Quartos.Add(quarto);
                _context.SaveChanges();
                return Created("", quarto);

            }
            catch ( System.Exception ex)
            {

                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message );
           
            }
        }

        
        [HttpGet]
        [Route("listquarto")]
        public List<Quarto> listquarto() => _context.Quartos.ToList();
        
        
        [HttpGet]
        [Route("getlistquartoporid/{id}")]
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um hotel por id
            Quarto quarto = _context.Quartos.Find(id);
            if (quarto == null)
            {
                return NotFound("Quarto não encontrado, catapimbas!");
            }
            return Ok(quarto);
        }


        //GET/api/quarto/delete/xxxx
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
             //Include(x => x.Historico).
            _context.SaveChanges();
            return Ok(_context.Quartos.ToList());
        }
    }
}