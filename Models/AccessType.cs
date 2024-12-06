using System.ComponentModel.DataAnnotations;

namespace BUMS{
    public enum AccessType{
        [Display(Name ="User")]
        User,
        [Display(Name ="UserAdmin")]
        UserAdmin,
        [Display(Name ="Admin")]
        Admin
    }
}
