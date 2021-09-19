using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;




namespace Transilvania.Controllers
{
    [ApiController]
    [Route("api/Reserva")]
    public class ReservaController : ControllerBase
    
    {

        private readonly DataContext _context;

        //Construtor
        public ReservaController(DataContext context) => _context = context;

        //!= diferente // || ou // ? IF
        //POST /api/reserva/create
        [HttpPost]
        [Route("create/{idUsuario}/{idQuarto}")]
        public IActionResult Create([FromBody] Reserva reserva, [FromRoute] int idUsuario, int idQuarto)
        {
            try
            {   
                if (reserva.CheckIn > reserva.CheckOut)
                {
                    throw new Exception ("Você não pode sair do Hotel sem ter entrado ... Ai que burro");
                }
                Usuario usuario = _context.Usuarios.Find(idUsuario);
                Quarto quarto = _context.Quartos.FirstOrDefault(x => x.Id == idQuarto); //Include(x => x.Reservas).
                reserva.Usuario = usuario;
                reserva.Quarto = quarto;
                if(reserva.Usuario == null || reserva.Quarto == null)
                    throw new Exception("Não foi possivel gerar uma reserva");
                    
                List<Reserva> reservasQuarto = _context.Reservas.Where(x => x.Quarto.Id == quarto.Id).ToList();
                var ocupado = false;
                reservasQuarto.ForEach(x => {
                    if((reserva.CheckIn >= x.CheckIn && reserva.CheckIn <= x.CheckOut)||(reserva.CheckOut >= x.CheckOut && reserva.CheckOut <= x.CheckOut))
                    {
                        ocupado = true;

                    }else if((x.CheckIn >= reserva.CheckIn && x.CheckIn <= reserva.CheckOut)||(x.CheckOut >= reserva.CheckOut && x.CheckOut <= reserva.CheckOut))
                    {
                        ocupado = true;
                    }
                });
                if (ocupado)
                {
                    throw new Exception("Data já reservada");
                }
                _context.Reservas.Add(reserva);
                _context.SaveChanges();
                return Created("", reserva); 
            }
            
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message );
            }

        }
 
        //GET /api/reserva/list
        [HttpGet]
        [Route("list")]
        public IActionResult list() 
        {
            try
            {
                var result = _context.Reservas.Include(x => x.Usuario).Include(x => x.Quarto).ToList();
                return result != null && result.Any() ? StatusCode(200, result): StatusCode(404, result); 
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
         [Route("listbyusuario/{id}")]
         public IActionResult listbyusuario([FromRoute] int id)
         {
             // Buscar um hotel por id
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