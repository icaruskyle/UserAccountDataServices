



using UserDataModel;

namespace UserAccountDataServices
{
    public class UserDataService
    {
        List<User> dummyUser= new List<User>();

        public UserDataService()
        {
            CreateDummyData();
        }
        private void CreateDummyData()
        {
            User user1 = new User();
            user1.userName = "Karyle" ;
            user1.password = "Dela Cruz";
            User user2 = new User();
            user2.userName = "Ellis" ;
            user2.password = "Arciaga";
            User user3 = new User();
            user3.userName = "Joana" ;
            user3.password = "Naval";

            dummyUser.Add(user1);
            dummyUser.Add(user2);
            dummyUser.Add(user3);
        }
        public User GetUser(string userName)
        {
            User foundUser = new User();
            
            foreach (var dummy in dummyUser)
            {
                if (userName == dummy.userName)
                {
                    foundUser = dummy;
                }
            }
            return foundUser;
        }
        }
}
