using esport.Enum;

namespace esport.DTOs
{
    public class CreateUserRequest
    {
        public string UserName { get; set; }
        public string Passoword { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}
