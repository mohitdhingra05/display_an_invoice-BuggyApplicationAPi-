
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace BuggyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInvoice()
        {
            List<Item> items = new List<Item>();
            if (items != null)
            {
                return Ok(items);
                InsertInvoicetoDB(items);
            }
            return NotFound("No invoice found");
        }

        public class Item
        {
            public string name { get; set; }
            public double price { get; set; }
        }

        public void InsertInvoicetoDB(Item item)
        {
            var result = _context.Invoice.Insert(item);
        }

    }
}
