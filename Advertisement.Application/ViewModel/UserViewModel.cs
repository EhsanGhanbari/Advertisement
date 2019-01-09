
namespace Advertisement.Application.ViewModel
{
    public class UserViewModel
    {
    }

    public class RegisterViewModel
    {
        public string Name { get; set; }

        public string Family { get; set; }

        public string Email { get; set; }
     
        public string Phone { get; set; }

        public string Password { get; set; }
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
