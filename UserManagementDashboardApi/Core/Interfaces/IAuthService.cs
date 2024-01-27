using UserManagementDashboardApi.Core.Dtos.Auth;
using UserManagementDashboardApi.Core.Dtos.General;

namespace UserManagementDashboardApi.Core.Interfaces
{
    public interface IAuthService
    {
        Task<GeneralServiceResponseDto> SeedRolesAsync();
        Task<GeneralServiceResponseDto> RegisterAsync(RegisterDto registerDto);
    }
}
