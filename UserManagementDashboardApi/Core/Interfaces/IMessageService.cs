using System.Security.Claims;
using UserManagementDashboardApi.Core.Dtos.General;
using UserManagementDashboardApi.Core.Dtos.Message;

namespace UserManagementDashboardApi.Core.Interfaces
{
    public interface IMessageService
    {
        Task<GeneralServiceResponseDto> CreateNewMessageAsync(ClaimsPrincipal User, CreateMessageDto createMessageDto);
        Task<IEnumerable<GetMessageDto>> GetMessagesAsync();
        Task<IEnumerable<GetMessageDto>> GetMyMessagesAsync(ClaimsPrincipal User);
    }
}
