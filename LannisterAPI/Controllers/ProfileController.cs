using System.Threading.Tasks;
using LannisterAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LannisterAPI.Controllers
{
  [Produces("application/json")]
  public class ProfileController : Controller
  {
    [HttpGet]
    [Route("profiles/{userId}")]
    [ProducesResponseType(typeof(ProfileOwnerProfile), 200)]
    [ProducesResponseType(typeof(UserProfile), 200)]
    [ProducesResponseType(typeof(Error), 400)]
    public async Task<IActionResult> GetUserProfile(string userId)
    {
      return Ok();
    }

    [HttpPost]
    [Route("profiles/{userId}/invitations")]
    [ProducesResponseType(200)]
    [ProducesResponseType(typeof(Error), 400)]
    public async Task<IActionResult> RespondOnTrackingInvitation([FromBody] RespondOnTrackingInvitationRequest request)
    {
      return Ok();
    }
  }
}