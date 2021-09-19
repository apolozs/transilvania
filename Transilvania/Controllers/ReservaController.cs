using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/Reserva")]
    public class ReservaController : ControllerBase
    
    {

        private readonly DataContext _context;

        //Construtor
        public ReservaController(DataContext context) => _context = context;

        //POST /api/reserva/create
        [HttpPost]
        [Route("create/{idUsuario}/{idQuarto}")]
        public IActionResult Create([FromBody] Reserva reserva, [FromRoute] int idUsuario, int idQuarto)
        {
            Usuario usuario = _context.Usuarios.Find(idUsuario);
            Quarto quarto = _context.Quartos.Find(idQuarto);
            reserva.Usuario = usuario;
            reserva.Quarto = quarto;
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
            return Created("", reserva);
        }
 


        //GET /api/reserva/list
        [HttpGet]
        [Route("list")]
        public List<Reserva> list() 
        {
             return _context.Reservas.Include(x => x.Usuario).Include(x => x.Quarto).ToList();
            
        }

        

        [HttpGet]
         [Route("listbyusuario/{id}")]
         public IActionResult listbyusuario([FromRoute] int id)
         {
             //Buscar um hotel por id
            List<Reserva> reserva = _context.Reservas.Include(x => x.Quarto).Include(x => x.Usuario).Where(x => x.Usuario.Id == id).ToList();
             if (reserva == null)
             {
                 return NotFound("reserva não encontrado, catapimbas!");
             }
             return Ok(reserva); //Quartos.Include(x => x.Historico).ToList();
         }




        //GET/api/reserva/getid/id
        [HttpGet]
        [Route("getid/{id}")]
    
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um reserva por id
            Reserva reserva = _context.Reservas.Find(id);
            if (reserva == null)
            {
                return NotFound("Reserva não encontrado, catapimbas!");
            }
            return Ok(reserva);
        }

        //GET/api/reserva/delete/xxxx
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete([FromRoute] int id)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Reserva reservas = _context.Reservas.Find(id);
            if (reservas == null)
            {
                return NotFound();
            }
            _context.Reservas.Remove(reservas);
            _context.SaveChanges();
            return Ok(_context.Reservas.ToList());
        }
        
    }

}