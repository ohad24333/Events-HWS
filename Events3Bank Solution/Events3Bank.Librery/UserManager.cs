using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events3Bank.Librery
{
    public class UserManager
    {
        static List<User> usersList = new List<User>()
        {
            new User("ohad","1234"),
            new User("eden","4321")
        };

        public EventHandler <User> SuccessLoginEvent;
        public EventHandler <string> UnSuccessLoginEvent;

        public void Login(string userName,string password)
        {
            foreach (var user in usersList)
            {
                if (user.UserName == userName)
                {
                    if (user.Password == password)
                    {
                        OnSuccessLoginEvent(this, user);
                        return;
                    }
                    else
                    {
                        OnUnSuccessLoginEvent(this,"Wrong Password");
                        return;
                    }  
                }
            }
            OnUnSuccessLoginEvent(this, "User Name Does Not Exist");

        }

        private void OnSuccessLoginEvent(UserManager userManager, User user)
        {
            if (SuccessLoginEvent != null)
            {
                SuccessLoginEvent(this, user);
            }
        }

        private void OnUnSuccessLoginEvent(UserManager userManager,string messege)
        {
            if (UnSuccessLoginEvent != null)
            {
                UnSuccessLoginEvent(this, messege);
            }
        }

    }
}
