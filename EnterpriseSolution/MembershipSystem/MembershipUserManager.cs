using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MembershipSystem
{
    public partial class MembershipUserManager<TUser> : MembershipUserManager<TUser, string>
        where TUser : class, Microsoft.AspNet.Identity.IUser<string>
    {


        // Summary:
        //     Constructor
        //
        // Parameters:
        //   store:
        public MembershipUserManager(IUserStore<TUser> store)
        {

        }

        public MembershipUserManager(IUserStore<TUser> store, string v)
        {
        }
        public MembershipUserManager()
        {

        }
    }
    public partial class MembershipUserManager<TUser, TKey>
        where TUser : class, Microsoft.AspNet.Identity.IUser<TKey>
        where TKey : System.IEquatable<TKey>
    {

    }


}
