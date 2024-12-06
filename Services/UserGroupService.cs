namespace BUMS{
    public class UserGroupService : IUserGroupService{
        BUMSDbContext context;
        public UserGroupService(BUMSDbContext service){
            context = service;
        }

        public void AddUserGroup(UserGroup userGroup){
            context.UserGroups.Add(userGroup);
            context.SaveChanges();
        }

        public void DeleteUserGroup(UserGroup userGroup){
            if (userGroup != null)
            {
                context.UserGroups.Remove(userGroup);
                context.SaveChanges();
            }
        }

        public IEnumerable<UserGroup> GetUserGroups(){
            return context.UserGroups;
        }   

        public UserGroup GetUserGroupById(int ID){
            return context.UserGroups.Find(ID);
        }

        public void UpdateUserGroup(UserGroup userGroup){
            using (context)
            {
                //var entity = context.Groups.FirstOrDefault(item => item.GroupID == userGroup.GroupID);
                //if (entity != null)
                //{
                //    context.SaveChanges();
                //}
            }
        }
    }
}
