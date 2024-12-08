using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BUMS{
    public class Group{
        [Display(Name = "Group id")]
        public int GroupID { get; set; }

        [Required]
        [Display(Name = "Group name")]
        [MaxLength(50), MinLength(0)]
        public string GroupName { get; set; }

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Created by")]
        public int CreatedBy { get; set; }

        //[Required]
        //[Display(Name = "Access")]
        //public Access Access {get;set;}

        [Display(Name = "AccessType")]
        [EnumDataType(typeof(AccessType))]
        [Required]
        public AccessType AccessType { get; set; }
        //public ICollection<UserGroup> UserGroups { get; set; }
    }
}
