using Login_Demo_MVC.DTO;
using Login_Demo_MVC.Models;

namespace Login_Demo_MVC.Classes
{
    public class LoginManager
    {
        //TODO: Make sql more generic
        MsSqlAccess SqlAccess { get; set; }

        public LoginManager(MsSqlAccess sqlAccess)
        {
            SqlAccess = sqlAccess;
        }

        public bool Login(LoginCredentModel loginCredent)
        {
            if (!SqlAccess.CheckForLockout(loginCredent.UserName))
            {
                User user = SqlAccess.GetUser(loginCredent.UserName);
                if (user != null)
                {
                    Console.WriteLine("");
                    return true;
                }
                else
                {
                    //There was no user found
                    return false;
                }
            }
            return false;
        }
    }
}
