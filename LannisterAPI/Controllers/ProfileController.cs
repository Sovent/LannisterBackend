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
    public class ProfileController : Controller
    {
        [HttpGet]
        [Route("profile/{userId}")]
        [ProducesResponseType(typeof(ProfileOwnerProfile), 200)]
        [ProducesResponseType(typeof(UserProfile), 200)]
        [ProducesResponseType(typeof(Error), 400)]
        public async Task<IActionResult> GetUserProfile(string userId)
        {
            return Ok();
        }
    }
}