using Microsoft.EntityFrameworkCore;

namespace BUMS{
    public class UserService : IUserService{
        BUMSDbContext context;
        public UserService(BUMSDbContext Service){
            context = Service;
        }

        public void AddUser(User user){
            user.UserNavigationId = idCounter++;
            context.Users.Add(user);
            context.SaveChangesAsync();
        }

        public User GetUserById(int ID){            
            return context.Users.FirstOrDefault(item => item.UserNavigationId == ID);
        }

        public void UpdateUser(User user, string UserName){
            using (context)
            {
                var entity = context.Users.FirstOrDefault(item => item.Id == user.Id);
                if (entity != null)
                {
                    entity.UserName = UserName;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteUser(User user){
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
        }

        public IEnumerable<User> GetUser(string filter){
            
            return this.context.Set<User>().Where(s => s.UserName.Contains(filter)).AsNoTracking().ToList();
        }

        public IEnumerable<User> GetUsers(){
          
            return context.Users;
        }
    }
}
