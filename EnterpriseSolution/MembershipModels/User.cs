using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MembershipModels
{

    [Table("MembershipUser")]
    public class User
    {
        public User()
        {
            UserQuestionAnswerLinks = new HashSet<UserQuestionAnswerLink>();
            UserRoleLinks = new HashSet<UserRoleLink>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string UserName
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        public string Password
        {
            get;
            set;
        }

        public DateTime? LastLoggedDate
        {
            get;
            set;
        }

        public virtual ICollection<UserQuestionAnswerLink> UserQuestionAnswerLinks
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
