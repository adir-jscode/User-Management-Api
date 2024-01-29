using System.Security.Claims;
using UserManagementDashboardApi.Core.Dtos.General;
using UserManagementDashboardApi.Core.Dtos.Message;
using UserManagementDashboardApi.Core.Interfaces;

namespace UserManagementDashboardApi.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageService _messageService;
        private readonly ILogService _logService;
       
        public MessageService()
        {
            
        }
        public Task<GeneralServiceResponseDto> CreateNewMessageAsync(ClaimsPrincipal User, CreateMessageDto createMessageDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetMessageDto>> GetMessagesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<GetMessageDto>> GetMyMessagesAsync(ClaimsPrincipal User)
        {
            throw new NotImplementedException();
        }
    }
}
