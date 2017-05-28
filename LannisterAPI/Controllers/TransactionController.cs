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
    public class TransactionController : Controller
    {
        [HttpGet]
        [Route("transactions")]
        [ProducesResponseType(typeof(UserTransactionsList), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetUserTransactions()
        {
            return Ok(new UserTransactionsList(
                Guid.NewGuid().ToString(),
                new[]
                {
                    new UserTransactionPreview(
                        Guid.NewGuid().ToString(),
                        Guid.NewGuid().ToString(),
                        "Kostya Huev",
                        new Uri("https://image.freepik.com/free-icon/male-user-shadow_318-34042.jpg"),
                        440F,
                        DateTimeOffset.UtcNow.AddDays(-5)), 
                    new UserTransactionPreview(
                        Guid.NewGuid().ToString(),
                        Guid.NewGuid().ToString(),
                        "Tanya Erofeeva",
                        new Uri("http://www.stickpng.com/assets/images/585e4bc4cb11b227491c3395.png"),
                        -1002F,
                        DateTimeOffset.UtcNow.AddDays(-20)) 
                }));
        }

        [HttpGet]
        [Route("tracking/{id}/transactions")]
        [ProducesResponseType(typeof(TrackingTransactionsList), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetTrackingTransactions(string trackingId)
        {
            return Ok();
        }
    }
}