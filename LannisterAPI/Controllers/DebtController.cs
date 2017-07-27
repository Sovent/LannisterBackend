using System;
using System.Threading.Tasks;
using LannisterAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LannisterAPI.Controllers
{
  [Produces("application/json")]
  public class DebtController : Controller
  {
    [HttpGet]
    [Route("debts")]
    [ProducesResponseType(typeof(UserDebtPreviewsList), 200)]
    [ProducesResponseType(typeof(Error), 400)]
    public async Task<IActionResult> GetUserDebts()
    {
      return Ok(new UserDebtPreviewsList(
        Guid.NewGuid().ToString(),
        new[]
        {
          new UserDebtPreview(
            Guid.NewGuid().ToString(),
            "Igor Petrov",
            new Uri("https://image.freepik.com/free-icon/male-user-shadow_318-34042.jpg"),
            -551.32),
          new UserDebtPreview(
            Guid.NewGuid().ToString(),
            "Anna Serofeeva",
            new Uri("http://www.stickpng.com/assets/images/585e4bc4cb11b227491c3395.png"),
            12332)
        }));
    }

    [HttpGet]
    [Route("trackings/{trackingId}/debts")]
    [ProducesResponseType(typeof(TrackingDebts), 200)]
    [ProducesResponseType(typeof(Error), 400)]
    public async Task<IActionResult> GetTrackingDebts(string trackingId)
    {
      return Ok();
    }
  }
}