using esport.Contracts.Business;
using esport.Contracts.Repository;
using esport.DTOs;
using esport.Models;

namespace esport.Business
{
	public class LoginBusiness : ILoginBusiness
    {
		private readonly ILoginRepository _repository;

		public LoginBusiness(ILoginRepository repository)
		{
			_repository = repository;
        }

        public LoginResponse login(LoginRequest request)
        {
			var response = new LoginResponse();
            try
			{
                var currentUser = _repository.Login(request);
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
