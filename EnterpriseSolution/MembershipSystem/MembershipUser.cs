using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MembershipModels;


namespace MembershipSystem
{
    /// <summary>
    /// Our User class inherits from the EF class so no need to do Id, userName, password.
    /// </summary>
    public class MembershipUser : MembershipModels.User, IUser<int> 
    {
        
    }
}
