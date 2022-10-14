using esport.Contracts.Business;
using esport.DB;
using esport.DTOs;

namespace esport.Business
{
	public class LoginBusiness : ILoginBusiness
    {
		private AppDbContext _dbContext;

		public LoginBusiness(AppDbContext dbContext)
		{
			_dbContext = dbContext;
        }

        public LoginResponse login(LoginRequest request)
        {
			var response = new LoginResponse();
            try
			{
                var currentUser = _dbContext.Users.Where(e => e.Username == request.Username)?.FirstOrDefault();
				if(currentUser == null)
				{
					response.Messsage = "User not found";
					response.Status = false;
                };

				if(currentUser.Password == request.Password)
				{
                    response.Messsage = "Logged In Successfully.";
                    response.Status = true;
                    response.Data = currentUser;
                }
				else
				{
                    response.Messsage = "Invalid Password";
                    response.Status = false;
                }

				return response;
            }
			catch (Exception)
			{
				throw;
			}
        }
    }
}
