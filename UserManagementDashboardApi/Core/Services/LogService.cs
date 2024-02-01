using Microsoft.EntityFrameworkCore;
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
        public async Task<IEnumerable<GetLogDto>> GetLogsAsync()
        {
           var logs = await _context.Logs.Select(x => new GetLogDto
           {
               UserName = x.UserName,
               Description = x.Description,
               
           }).OrderByDescending(q => q.CreatedAt).ToListAsync();
            return logs;
        }

        public async Task<IEnumerable<GetLogDto>> GetMyLogsAsync(ClaimsPrincipal User)
        {
            var myLogs = await _context.Logs.Where(q => q.UserName == User.Identity.Name).Select(q => new GetLogDto
            {
                UserName = q.UserName,
                Description = q.Description,
                CreatedAt = q.CreatedAt,
            }).OrderByDescending(x=>x.CreatedAt).ToListAsync();
            return myLogs;
        }

        
    }
}
