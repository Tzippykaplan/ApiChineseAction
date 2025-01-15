using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetories
{
    public class UserReposetory : IUserReposetory
    {
        static int Identity = 1;
       public static List<User> users = [new User() { Id = Identity++, FirstName = "ari", LastName = "chon", Email="a@gmail.com", Password="1",Phone="0548552214" ,Role=RoleType.ADMIN},
            new User() { Id = Identity++, FirstName = "mmm", LastName = "gg", Email = "b@gmail.com",Password="2",Phone="0504107477" }, 
           new User() { Id = Identity++, FirstName = "mmm", LastName = "gg", Email = "c@gmail.com",Password="3",Phone="0504107477" }];
        public async Task<List<User>> getUsers()
        {
            return users; ;



        }
        public async Task<User> getById(int id)
        {

            return users.FirstOrDefault<User>(currenUser => currenUser.Id == id);


        }
        public async Task<User> createUser(User User)
        {
            User.Id = Identity++;
            users.Add(User);
            return (User);
        }

        public async Task<User> updateUser(int id, User userToUpdate)
        {
            User? user = users.Find(currenUser => currenUser.Id == id);

            if (user == null)
            {
                return null;
            }
            user.FirstName = userToUpdate.FirstName;
            user.LastName = userToUpdate.LastName;
            user.Email = userToUpdate.Email;
            return (user);

        }
        public async Task<User> login(string email, string password)
        {
             User? user = users.Find(currenUser => currenUser.Email == email && currenUser.Password==password);
            return (user);
        }

        public async Task deleteUser(int id)
        {

            users.RemoveAll(currenUser => currenUser.Id == id);


        }

    }
}
