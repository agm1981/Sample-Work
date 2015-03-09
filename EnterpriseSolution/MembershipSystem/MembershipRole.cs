using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace MembershipSystem
{
    public class MembershipRole : MembershipModels.Role, IRole
    {
        public MembershipRole(string name) : this()
        {
            Name = name;
        }

        public MembershipRole(string name, string id)
        {
            Name = name;
            Id = id;
        }

        public MembershipRole()
        {
        
        }
    }
}
