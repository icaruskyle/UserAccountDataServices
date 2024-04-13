using UserAccountDataServices;

namespace UserAccountBusiness
{
    public class UserService
    {
        public bool VerifyUser(string userName, string password)
        {
            UserDataService dataService = new UserDataService();
            var result = dataService.GetUser( userName);

            return result.userName != null ? true : false;
            //return result.password != null ? true : false;
        }
    }
}
