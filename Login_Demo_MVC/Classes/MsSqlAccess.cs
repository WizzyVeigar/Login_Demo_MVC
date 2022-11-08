using Login_Demo_MVC.DTO;
using System.Data.SqlClient;

namespace Login_Demo_MVC.Classes
{
    public class MsSqlAccess
    {
        private IConfiguration config;
        SqlConnection conn;
        SqlCommand command;
        public MsSqlAccess(IConfiguration _config)
        {
            config = _config;
            conn = new SqlConnection(config.GetConnectionString("connString"));
        }


        public bool RegiserUser(string username, string hashedPass, string salt)
        {
            //save into db
            return false;
        }

        public bool LoginUser(User user, string attemptedPass)
        {
            return false;
        }

        public User GetUser(string username)
        {
            return null;
        }

        public bool CheckForLockout(string username)
        {
            return false;
        }
    }
}
