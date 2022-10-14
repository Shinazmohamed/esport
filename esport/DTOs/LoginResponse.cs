using esport.Models;

namespace esport.DTOs
{
    public class LoginResponse: BaseResponse
    {
        public User Data { get; set; }
    }
}
