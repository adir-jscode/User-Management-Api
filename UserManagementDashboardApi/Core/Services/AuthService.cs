using Microsoft.AspNetCore.Identity;
using UserManagementDashboardApi.Core.Dtos.Auth;
using UserManagementDashboardApi.Core.Dtos.General;
using UserManagementDashboardApi.Core.Entities;
using UserManagementDashboardApi.Core.Interfaces;

namespace UserManagementDashboardApi.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralServiceResponseDto> SeedRolesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
