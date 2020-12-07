using System.Collections.Generic;
using System.Threading.Tasks;
using datingApp.API.Data;
using datingApp.API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace datingApp.API.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly DataContext _Context;

        public UsersController(DataContext Context)
        {
            _Context = Context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _Context.Users.ToListAsync();
        }

        [Authorize]
        // api/users/3
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            return await _Context.Users.FindAsync(id);
        }
    }
}