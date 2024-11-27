using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BUMS.Models{
    [Table("UserGroup")]
    public class UserGroup{
        [Key]
        [Column("UserGroup_Id")]
        public int UserGroupID {get;set;}

        [Column("User_Id")]
        public int UserID {get;set;}
        [Column("Group_Id")]
        public int GroupID{get;set;}
        [Column("Access_Id")]
        public int AccessID{get;set;}

        [ForeignKey(nameof(UserID))]
        [InverseProperty(nameof(User.UserGroups))]
        public virtual UserGroup UserUserGroupNavigation {get;set;}

        [ForeignKey(nameof(AccessID))]
        [InverseProperty(nameof(Access.UserGroups))]
        public virtual Access AccessUserGroupNavigation {get;set;}

        [ForeignKey(nameof(GroupID))]
        [InverseProperty(nameof(Group.UserGroups))]
        public virtual Group GroupUserGroupNavigation {get;set;}
    }
}
