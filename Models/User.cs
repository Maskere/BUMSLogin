using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BUMS.Models{
    public class User{
        [Key]
        [Column("User_Id")]
        public int UserId {get;set;}

        [Column("User_Name")]
        public string UserName {get;set;}

        [Column("Created_At")]
        public DateTime CreatedAt {get;set;}

        [Column("Created_By")]
        public User CreatedBy {get;set;}
    }
}
