using System.ComponentModel.DataAnnotations;

namespace UserManagementDashboardApi.Core.Dtos.Auth
{
    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage ="Username is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
