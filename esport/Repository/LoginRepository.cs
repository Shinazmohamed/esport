using esport.Contracts.Repository;
using esport.DB;
using esport.DTOs;
using esport.Models;

namespace esport.Repository
{
    public class LoginRepository: ILoginRepository
    {
        private AppDbContext _dbContext;
        public LoginRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Login(LoginRequest request)
        {
            try
            {
                return _dbContext.Users.Where(e => e.Username == request.Username)?.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
