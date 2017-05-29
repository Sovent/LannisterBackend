using System;
using System.Threading.Tasks;
using LannisterAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LannisterAPI.Controllers
{
    [Produces("application/json")]
    public class TrackingController : Controller
    {
        [HttpGet]
        [Route("trackings")]
        [ProducesResponseType(typeof(TrackingList), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetUserTrackings()
        {
            return Ok(
                new TrackingList(
                    Guid.NewGuid().ToString(),
                    new[]
                    {
                        new TrackingPreview(
                            Guid.NewGuid().ToString(),
                            "Tracking Name",
                            -342.23F,
                            6,
                            "USD",
                            true),
                        new TrackingPreview(
                            Guid.NewGuid().ToString(),
                            "Another tracking name",
                            960F,
                            2,
                            "RUR",
                            false)
                    }));
        }

        [HttpGet]
        [Route("trackings/{id}")]
        [ProducesResponseType(typeof(Tracking), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetTracking(string id)
        {
            var participants = new[]
            {
                new TrackingParticipant(Guid.NewGuid().ToString(), "Jessica Jones", "Jjones", new Uri("https://typeset-beta.imgix.net/2017%2F2%2F15%2Fa7a7b3ca-2255-4625-9fb9-fefdb19a5a96.jpg"), true),
                new TrackingParticipant(Guid.NewGuid().ToString(), "Sergey Piterskiy", "pitor", new Uri("https://image.freepik.com/free-icon/male-user-shadow_318-34042.jpg"), true),
                new TrackingParticipant(Guid.NewGuid().ToString(), "Herman Gold", "X-Man", new Uri("https://image.freepik.com/free-icon/male-user-shadow_318-34042.jpg"), false) 
            };

            return Ok(new Tracking(
                id,
                "Tracking name", 
                "RUB",
                participants,
                participants[0].Id,
                DateTimeOffset.UtcNow.AddDays(-23),
                null));
        }

        [HttpPost]
        [Route("trackings")]
        [ProducesResponseType(typeof(CreateTrackingResponse), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> CreateTracking([FromBody] CreateTrackingRequest createTrackingRequest)
        {
            return Ok();
        }

        [HttpPost]
        [Route("trackings/{trackingId}/users/{userId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> InviteUser(string trackingId, string userId)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("trackings/{trackingId}/users/{userId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> DeleteUser(string trackingId, string userId)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("trackings/{trackingId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> CloseTracking(string trackingId)
        {
            return Ok();
        }
    }
}