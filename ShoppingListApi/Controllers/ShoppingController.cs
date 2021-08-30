using Microsoft.AspNetCore.Mvc;
using ShoppingListApi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListApi.Controllers
{
    public class ShoppingController : ControllerBase
    {
        private readonly ShoppingDataContext _context;

        public ShoppingController(ShoppingDataContext context)
        {
            _context = context;
        }

        [HttpGet("shopping")]
        public ActionResult GetShoppingList()
        {
            var items = _context.ShoppingItems.ToList();
            return Ok(items);
        }
    }
}
