using System.Security.Claims;
using UserManagementDashboardApi.Core.Dtos.Auth;
using UserManagementDashboardApi.Core.Dtos.General;

namespace UserManagementDashboardApi.Core.Interfaces
{
    public interface IAuthService
    {
        Task<GeneralServiceResponseDto> SeedRolesAsync();
        Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto);
        Task<LoginServiceResponseDto> LoginAsync(LoginDto loginDto);
        Task<GeneralServiceResponseDto> UpdateRoleAsync(ClaimsPrincipal User,UpdateRoleDto updateRoleDto);
        Task<LoginServiceResponseDto> MeAsync(MeDto meDto);
        Task<IEnumerable<UserInfoResult>> GetUserListAsync();
        Task<UserInfoResult> GetUserDetailsByUserName(string userName);
        Task<IEnumerable<string>> GetUsernamesListAsync();
    }
}
