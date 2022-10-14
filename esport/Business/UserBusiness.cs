using esport.Contracts.Business;
using esport.DB;
using esport.DTOs;
using esport.Models;

namespace esport.Business
{
    public class UserBusiness : IUserBusiness
    {
		private AppDbContext _appDbContext;

		public UserBusiness(AppDbContext context)
		{
            _appDbContext = context;
        }

        public bool Create(CreateUserRequest request)
        {
			try
			{
                var entity = new User()
                {
                    Username = request.UserName,
                    Password = request.Passoword,
                    UserType = request.UserType.ToString()
                };

                _appDbContext.Users.Add(entity);
                _appDbContext.SaveChanges();

                return true;
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
