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

        public string UserCat {
            get {
                if (this.UserAge < 18)
                {
                    return "Child";
                } else if (this.UserAge > 60)
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
            this.UserName = userName;
            this.UserId = userId;
            this.UserAge = userAge;
        }

        public override string ToString()
        {

            return this.UserName + "\t" +this.UserId +this.UserAge+"\t"+this.UserCat;
        }
    }
}
