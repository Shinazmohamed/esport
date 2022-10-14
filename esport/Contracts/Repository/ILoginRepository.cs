using esport.DTOs;
using esport.Models;

namespace esport.Contracts.Repository
{
    public interface ILoginRepository
    {
        User Login(LoginRequest request);
    }
}
