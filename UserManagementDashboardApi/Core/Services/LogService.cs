using System.Security.Claims;
using UserManagementDashboardApi.Core.DbContext;
using UserManagementDashboardApi.Core.Dtos.Log;
using UserManagementDashboardApi.Core.Entities;
using UserManagementDashboardApi.Core.Interfaces;

namespace UserManagementDashboardApi.Core.Services
{
    public class LogService : ILogService
    {
        private readonly ApplicationDbContext _context;
        public LogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SaveNewLog(string UserName, string Description)
        {
            var newLog = new Log()
            {
                UserName = UserName,
                Description = Description
            };
            await _context.AddAsync(newLog);
            await _context.SaveChangesAsync();
        }
        public  Task<IEnumerable<GetLogDto>> GetLogsAsync()
        {
           throw new NotImplementedException();
        }

        public Task<IEnumerable<GetLogDto>> GetMyLogsAsync(ClaimsPrincipal User)
        {
            throw new NotImplementedException();
        }

        
    }
}
