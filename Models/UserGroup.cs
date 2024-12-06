using System.ComponentModel.DataAnnotations;

namespace BUMS{
    public class UserGroup{
        public int UserGroupID { get; set; }

        [Required]
        [Display(Name = "User")]
        public User User { get; set; }
        //public int UserID { get; set; }

        [Required]
        [Display(Name = "Group")]
        public Group Group { get; set; }
        //public int GroupID { get; set; }
    }
}
