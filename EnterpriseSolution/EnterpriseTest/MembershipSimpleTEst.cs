using System;
using DataAccessLayer;
using MembershipModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EnterpriseTest
{
    [TestClass]
    public class MembershipSimpleTEst
    {
        [TestMethod]
        public void TestMethod1()
        {
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
