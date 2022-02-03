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
    public class CartItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/CartItems
        [HttpGet]
        public async Task<IActionResult> GetCartItems()
        {
            var cartitem = await _unitOfWork.CartItems.GetAll();
            return Ok(cartitem);
        }

        // GET: api/CartItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCartItems(int id)
        {
            var cartitem = await _unitOfWork.CartItems.Get(q => q.ID == id);

            if (cartitem == null)
            {
                return NotFound();
            }

            return Ok(cartitem);
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCartItems(int id, CartItem cartitem)
        {
            if (id != cartitem.ID)
            {
                return BadRequest();
            }

            _unitOfWork.CartItems.Update(cartitem);

            try
            {
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CartItemsExists(id))
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

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CartItem>> PostCartItems(CartItem cartitem)
        {
            //_context.CartItems.Add(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CartItems.Insert(cartitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCartItems", new { id = cartitem.ID }, cartitem);
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCartItems(int id)
        {
            //var category = await _context.CartItems.FindAsync(id);
            var cartitem = await _unitOfWork.CartItems.Get(q => q.ID == id);
            if (cartitem == null)
            {
                return NotFound();
            }

            //_context.CartItems.Remove(category);
            //await _context.SaveChangesAsync();
            await _unitOfWork.CartItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CartItemsExists(int id)
        private async Task<bool> CartItemsExists(int id)
        {
            //return _context.CartItems.Any(e => e.Id == id);
            var cartitem = await _unitOfWork.CartItems.Get(q => q.ID == id);
            return cartitem != null;
        }
    }
}
