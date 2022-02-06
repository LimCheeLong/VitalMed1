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
    public class CartsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Carts
        [HttpGet]
        public async Task<IActionResult> GetCarts()
        {
            var cart = await _unitOfWork.Cart.GetAll();
            return Ok(cart);
        }

        // GET: api/Carts/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarts(int id)
        {
            var cart = await _unitOfWork.Cart.Get(q => q.ID == id);

            if (cart == null)
            {
                return NotFound();
            }

            return Ok(cart);
        }

        // PUT: api/Carts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarts(int id, Cart cart)
        {
            if (id != cart.ID)
            {
                return BadRequest();
            }

            _unitOfWork.Cart.Update(cart);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CartsExists(id))
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

        // POST: api/Carts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cart>> PostCarts(Cart cart)
        {
            //_context.Carts.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Cart.Insert(cart);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCarts", new { id = cart.ID }, cart);
        }

        // DELETE: api/Carts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarts(int id)
        {
            //var category = await _context.Carts.FindAsync(id);
            var cart = await _unitOfWork.Cart.Get(q => q.ID == id);
            if (cart == null)
            {
                return NotFound();
            }

            //_context.Carts.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Cart.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CartsExists(int id)
        private async Task<bool> CartsExists(int id)
        {
            //return _context.Carts.Any(e => e.Id == id);
            var cart = await _unitOfWork.Cart.Get(q => q.ID == id);
            return cart != null;
        }
    }
}
