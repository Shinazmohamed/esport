using esport.DTOs;

namespace esport.Contracts.Business
{
    public interface IUserBusiness
    {
        bool Create(CreateUserRequest request);
    }
}
