using JWTAuth.Models;

namespace JWTAuth.Interface
{
    public interface IAuthService
    {
        public Task<User> Login(string email, string password);
        public Task<User> Register(User user);
    }
}
