namespace UserManagementDashboardApi.Core.Dtos.Message
{
    public class CreateMessageDto
    {
        public string ReceiverName { get; set; }
        public string Text { get; set; }
        public string? ReceiverUserName { get; internal set; }
    }
}
