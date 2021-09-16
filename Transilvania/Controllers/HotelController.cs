using System.Collections.Generic;
using Transilvania.Data;
using Transilvania.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Transilvania.Controllers

{
    [ApiController]
    [Route("api/Hotel")]
    public class HotelController : ControllerBase

    {
        
        private readonly DataContext _context;

        //Construtor
        public HotelController(DataContext context) => _context = context;

        //POST /api/hotel/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Hotel hotel)
        {

            _context.Hoteis.Add(hotel);
            _context.SaveChanges();
            return Created("", hotel);
        }

        //GET /api/hotel/list
        [HttpGet]
        [Route("list")]

        public List<Hotel> list() => _context.Hoteis.Include(x => x.Quarto).ToList();
        
                //GET/api/hotel/getid/id
        [HttpGet]
        [Route("getid/{id}")]
        public IActionResult getid([FromRoute] int id)
        {
            //Buscar um hotel por id
            Hotel hotel = _context.Hoteis.Find(id);
            if (hotel == null)
            {
                return NotFound("hotel não encontrado, catapimbas!");
            }
            return Ok(hotel);
        }

        //GET/api/hotel/delete/xxxx
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult delete([FromRoute] string name)
        {
            
            //Expressão lambda
            //Buscar UM produto pelo nome
            Hotel hotel = _context.Hoteis.FirstOrDefault(hotel => hotel.Nome == name);
            if (hotel == null)
            {
                return NotFound();
            }
            _context.Hoteis.Remove(hotel);
            _context.SaveChanges();
            return Ok(_context.Hoteis.ToList());
        }
    }
}