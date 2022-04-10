using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_Management_System1.manager
{
    public static class UserManager
    {
        public static void addUser(string name , string password)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
                db.Users.Add(new User
                {

                    username = name,
                    password = password,
                    type = "employees"

                });
                db.SaveChanges();
            }
        }

        public static User singIn(string username, string password)
        {
            using (AirplainDBEntities db = new AirplainDBEntities())
            {
              return db.Users.SingleOrDefault(x => x.username == username && x.password == password);
              
            }
        }


       


    }
}
