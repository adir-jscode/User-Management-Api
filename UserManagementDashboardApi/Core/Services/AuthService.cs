using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
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

        public Task<UserInfoResult> GetUserDetailsByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserInfoResult>> GetUserListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<string>> GetUsernamesListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<LoginServiceResponseDto> LoginAsync(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public Task<LoginServiceResponseDto> MeAsync(MeDto meDto)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto)
        {
            throw new NotImplementedException();
        }

        public Task<GeneralServiceResponseDto> SeedRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GeneralServiceResponseDto> UpdateRoleAsync(ClaimsPrincipal User, UpdateRoleDto updateRoleDto)
        {
            throw new NotImplementedException();
        }
    }
}
