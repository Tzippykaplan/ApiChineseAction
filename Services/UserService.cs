using Entities;
using Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        IUserReposetory _usersReposetory;
        public UserService(IUserReposetory _usersReposetory)
        {
            this._usersReposetory = _usersReposetory;
        }
        public async Task<List<User>> getUsers()
        {
            return await _usersReposetory.getUsers();

        }
        public async Task<User> getById(int id)
        {

            return await _usersReposetory.getById(id);


        }
        public async Task<User> createUser(User user)
        {
            return await _usersReposetory.createUser(user);
        }
        public async Task<User> updateUser(int id, User userToUpdate)
        {
            return await _usersReposetory.updateUser(id, userToUpdate);

        }
        public async Task<User> login(string email, string password)
        {
            return await _usersReposetory.login(email, password);

        }
        public async Task deleteUser(int id)
        {

            _usersReposetory.deleteUser(id);


        }
    }
}
