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
        [Route("trackings/{trackingId}/checkouts")]
        [ProducesResponseType(typeof(TrackingCheckoutPreviewList), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetTrackingCheckouts(string trackingId)
        {
            return Ok();
        }

        [HttpGet]
        [Route("checkouts/{checkoutId}")]
        [ProducesResponseType(typeof(Checkout), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetCheckout(string checkoutId)
        {
            return Ok();
        }

        [HttpPost]
        [Route("checkouts")]
        [ProducesResponseType(typeof(CreateCheckoutResponse), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> CreateCheckout([FromBody] CreateCheckoutRequest request)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("checkouts/{checkoutId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> DeleteCheckout(string checkoutId)
        {
            return Ok();
        }
    }
}