using Entities;

namespace Reposetories
{
    public interface IUserReposetory
    {
        Task<User> createUser(User User);
        Task deleteUser(int id);
        Task<User> getById(int id);
        Task<List<User>> getUsers();
        Task<User> updateUser(int id, User userToUpdate);
        Task<User> login(string email, string password);

    }
}