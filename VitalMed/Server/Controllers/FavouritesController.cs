using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitalMed.Server.Data;
using VitalMed.Shared.Domain;
using VitalMed.Server.IRepository;

namespace VitalMed.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouritesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public FavouritesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Favourites
        [HttpGet]
        public async Task<IActionResult> GetFavourites()
        {
            var favourites = await _unitOfWork.Favourites.GetAll();
            return Ok(favourites);
        }

        // GET: api/Favourites/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFavourite(int id)
        {
            var favourite = await _unitOfWork.Favourites.Get(q => q.ID == id);

            if (favourite == null)
            {
                return NotFound();
            }

            return Ok(favourite);
        }

        // PUT: api/Favourites/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavourite(int id, Favourite favourite)
        {
            if (id != favourite.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Favourites.Update(favourite);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FavouriteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Favourites
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Favourite>> PostFavourite(Favourite favourite)
        {
            //_context.Favourite.Add(favourite);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Favourites.Insert(favourite);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFavourite", new { id = favourite.ID }, favourite);
        }

        // DELETE: api/Favourites/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavourite(int id)
        {
            //var favourite = await _context.Favourite.FindAsync(id);
            var favourite = await _unitOfWork.Favourites.Get(q => q.ID == id);
            if (favourite == null)
            {
                return NotFound();
            }

            //_context.Favourite.Remove(favourite);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Favourites.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool FavouriteExists(int id)
        private async Task<bool> FavouriteExists(int id)
        {
            //return _context.Favourite.Any(e => e.Id == id);
            var favourite = await _unitOfWork.Favourites.Get(q => q.ID == id);
            return favourite != null;
        }
    }
}
