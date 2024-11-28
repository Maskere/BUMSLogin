using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BUMS.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public DateTime CreatedAt { get; set; }
        public User CreatedBy { get; set; }

        //public virtual ICollection<UserGroup> GroupUserGroups { get; set; }
    }
}
