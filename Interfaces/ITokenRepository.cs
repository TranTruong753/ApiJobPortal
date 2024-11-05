using Backend.Models;

namespace Backend.Interfaces
{
    public interface ITokenRepository
    {
        string CreateToken(AppUser user);
    }
}
