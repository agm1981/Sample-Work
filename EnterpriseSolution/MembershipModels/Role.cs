using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipModels
{
     [Table("MembershipRole")]
    public class Role
    {
        public Role()
        {
            UserRoleLinks = new List<UserRoleLink>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Index(IsUnique = true)]
        public string Id
        {
            get;
            set;
        }

        [Index(IsUnique = true)]
        public string Name
        {
            get;
            set;
        }
        public virtual ICollection<UserRoleLink> UserRoleLinks
        {
            get;
            set;
        }

    }
}
