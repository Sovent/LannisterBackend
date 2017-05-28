using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LannisterAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LannisterAPI.Controllers
{
    [Produces("application/json")]
    public class CheckoutController : Controller
    {
        [HttpGet]
        [Route("tracking/{trackingId}/checkouts")]
        [ProducesResponseType(typeof(TrackingCheckoutPreviewList), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetTrackingCheckouts(string trackingId)
        {
            return Ok();
        }
    }
}