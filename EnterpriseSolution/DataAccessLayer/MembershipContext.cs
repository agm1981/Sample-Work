using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipModels;

namespace DataAccessLayer
{
    public class MembershipContext : DbContext
    {
        public DbSet<User> MembershipUsers
        {
            get;
            set;
        }
        public DbSet<QuestionAnswer> MembershipQuestionAnswers
        {
            get;
            set;
        }
        public DbSet<UserQuestionAnswerLink> MembershipUserQuestionAnswerLinks
        {
            get;
            set;
        }


        public DbSet<Role> MembershipRoles
        {
            get;
            set;
        }
        public DbSet<UserRoleLink> UserRoleLinks
        {
            get;
            set;
        }
      


        static MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }

        public MembershipContext()
            : base("Name=MembershipSystem")
        {
            Configuration.LazyLoadingEnabled = true;
        }




    }
}
