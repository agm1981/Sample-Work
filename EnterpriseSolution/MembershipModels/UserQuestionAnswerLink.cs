
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MembershipModels
{
    [Table("MembershipUserQuestionAnswerLink")]
    public class UserQuestionAnswerLink
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
        {
            get;
            set;
        }

        
        [Required]
        [ForeignKey("User")]
        public int UserId
        {
            get;
            set;
        }

        
        [Required]
        [ForeignKey("QuestionAnswer")]
        public int QuestionAnswerId
        {
            get;
            set;
        }

        public virtual QuestionAnswer QuestionAnswer
        {
            get;
            set;
        }

        public virtual User User
        {
            get;
            set;
        }
    }
}
