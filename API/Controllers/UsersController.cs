using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using datingApp.API.Data;
using datingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace datingApp.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class UsersController : ControllerBase
  {
    private readonly DataContext _Context;
    public UsersController(DataContext Context)
    {
      _Context = Context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
      return await _Context.Users.ToListAsync();
    }

    // api/users/3
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUsers(int id)
    {
      return await _Context.Users.FindAsync(id);
    }

  }
}