using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BUMS.Models
{
        public class Access
    {
        [Display(Name = "Access id")]
        [Required]
        public int AccessID { get; set; }
        [Display(Name = "Access name")]
        [Required]
        public string AccessName { get; set; }
        [Display(Name = "System name")]
        [Required]
        public string SystemName { get; set; }
        public ICollection<UserGroup> UserGroups { get; set; }
    }
}
