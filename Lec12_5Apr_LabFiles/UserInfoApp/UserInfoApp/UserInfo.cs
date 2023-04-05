using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInfoApp
{
    internal class UserInfo
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public double UserAge { get; set; }
        public string UserCategory
        {
            get
            {
                if (UserAge < 18)
                {
                    return "Child";
                } else if (UserAge >= 60)
                {
                    return "Senior Citizen";
                } else
                {
                    return "Adult";
                }
            }
        }

        public UserInfo(string userName, int userId, double userAge)
        {
            UserName = userName;
            UserId = userId;
            UserAge = userAge;
        }

        public override string ToString()
        {
            string outputStr = string.Format("{0,-15}{1,-5}{2,-8:F2}{3,-10}", 
                                    UserName, UserId, UserAge, UserCategory);
            return outputStr;
        }

    }
}
