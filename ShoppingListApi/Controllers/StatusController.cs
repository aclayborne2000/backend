using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListApi.Controllers
{
    public class StatusController : ControllerBase
    {
        // GET /status
        [HttpGet("status")]
        public ActionResult GetTheStatus()
        {
            // run some REAL code that checks out the status
            var response = new StatusResponse
            {
                Message = "The Server is operating normally",
                WhenChecked = DateTime.Now
            };
            return Ok(response);
        }
    }

    public record StatusResponse
    {
        public string Message { get; init; }
        public DateTime WhenChecked { get; init; }
    }
}
