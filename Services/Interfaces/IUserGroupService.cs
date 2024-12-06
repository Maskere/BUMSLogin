namespace BUMS{
    public interface IUserGroupService{
        IEnumerable<UserGroup> GetUserGroups();
        void AddUserGroup(UserGroup userGroup);
        void DeleteUserGroup(UserGroup userGroup);
        public UserGroup GetUserGroupById(int ID);
        public void UpdateUserGroup(UserGroup userGroup);
    }
}
