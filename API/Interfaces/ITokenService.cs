using datingApp.API.Entities;

namespace datingApp.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}