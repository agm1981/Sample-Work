using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MembershipModels;
using Microsoft.AspNet.Identity;

namespace MembershipSystem
{
    public class MembershipUserManager<TUser, TKey> : IDisposable
        where TUser : class, IUser<TKey>
        where TKey : System.IEquatable<TKey>
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class MembershipUserManager<TUser> : MembershipUserManager<TUser, string> where TUser : class, IUser<string>
    {
        public MembershipUserManager(IUserStore<TUser> store)
        {
        
        }

        public MembershipUserManager()
        {
            ;
        }


        public Task<ClaimsIdentity> CreateIdentityAsync(MembershipApplicationUser membershipApplicationUser, string authenticationType)
        {
            throw new NotImplementedException();
        }
    }
}
