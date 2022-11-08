namespace Login_Demo_MVC.DTO
{
    public class User
    {
        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string uSalt;

        public string USalt
        {
            get { return uSalt; }
            set { uSalt = value; }
        }

        private string uPass;
        /// <summary>
        /// The user's password from the database in base64 string format
        /// </summary>
        public string UPass
        {
            get { return uPass; }
            set { uPass = value; }
        }

        public User(string userName, string uSalt, string uPass)
        {
            UserName = userName;
            USalt = uSalt;
            UPass = uPass;
        }
    }
}
