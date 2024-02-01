using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using UserManagementDashboardApi.Core.DbContext;
using UserManagementDashboardApi.Core.Dtos.General;
using UserManagementDashboardApi.Core.Dtos.Message;
using UserManagementDashboardApi.Core.Entities;
using UserManagementDashboardApi.Core.Interfaces;

namespace UserManagementDashboardApi.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogService _logService;
        private readonly UserManager<ApplicationUser> _userManager;

        public async Task<GeneralServiceResponseDto> CreateNewMessageAsync(ClaimsPrincipal User, CreateMessageDto createMessageDto)
        {
            if (User.Identity.Name == createMessageDto.ReceiverName)
            { 
                return new GeneralServiceResponseDto()
                {
                    IsSucceed = false,
                    StatusCode = 400,
                    Message = "User Can't be same"
                };
            }
            //var IsValidUser = _userManager.Users.Any(User.Identity.Name == createMessageDto.ReceiverName);
            //if(!IsValidUser)
            //{
            //    return new GeneralServiceResponseDto()
            //    {
            //        IsSucceed = false,
            //        StatusCode = 400,
            //        Message = "User is not found"
            //    };
            //}
            Message newMessage = new Message()
            {
                SenderUserName = User.Identity.Name,
                ReceiverUserName = createMessageDto.ReceiverName,
                Text = createMessageDto.Text,
            };
            await _context.AddAsync(newMessage);
            await _context.SaveChangesAsync();



            return new GeneralServiceResponseDto()
            {
                IsSucceed = true,
                StatusCode = 201,
                Message = "Message sent Successfully"
            };
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

