using esport.DTOs;
using esport.Models;

namespace esport.Contracts.Business
{
    public interface ILoginBusiness
    {
        LoginResponse login(LoginRequest request);
    }
}
