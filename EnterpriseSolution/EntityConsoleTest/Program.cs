using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using MembershipModels;

namespace EntityConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            HibernatingRhinos.Profiler.Appender.EntityFramework.EntityFrameworkProfiler.Initialize();
            using (var ct = new MembershipContext())
            {
                User user = new User
                {
                    Password = "password",
                    UserName = "username"
                };
                ct.MembershipUsers.Add(user);

                ct.SaveChanges();

            }
        }
    }
}
