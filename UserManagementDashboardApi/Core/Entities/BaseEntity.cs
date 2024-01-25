namespace UserManagementDashboardApi.Core.Entities
{
    public class BaseEntity<TID>
    {
        public TID Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt {  get; set; }
        public bool IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}
