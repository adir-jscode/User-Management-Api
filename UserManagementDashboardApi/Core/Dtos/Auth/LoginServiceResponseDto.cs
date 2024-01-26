namespace UserManagementDashboardApi.Core.Dtos.Auth
{
    public class LoginServiceResponseDto
    {
        public string NewToken { get; set; }

        //This will be return to front-end

        public UserInfoResult UserInfo { get; set; }
    }
}
