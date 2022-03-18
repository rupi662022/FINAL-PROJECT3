using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FINAL_PROJECT3.Models
{
    public class User
    {
        int userID;
        string userName;
        string userEmail;
        string userPassword;
        string userType;

        public User() { }

        public User(int userID, string userName, string userEmail, string userPassword, string userType)
        {
            this.userID = userID;
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.userType = userType;
        }

        public int UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserType { get => userType; set => userType = value; }
    }
}