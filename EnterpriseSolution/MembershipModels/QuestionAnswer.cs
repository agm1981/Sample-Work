
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipModels
{
    [Table("MembershipQuestionAnswer")]
    public class QuestionAnswer
    {
        public QuestionAnswer()
        {
            UserQuestionAnswerLinks = new HashSet<UserQuestionAnswerLink>();
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
        public string Question
        {
            get;
            set;
        }

        [Required]
        [StringLength(50)]
        public string Answer
        {
            get;
            set;
        }

        public virtual ICollection<UserQuestionAnswerLink> UserQuestionAnswerLinks
        {
            get;
            set;
        }
    }
}
