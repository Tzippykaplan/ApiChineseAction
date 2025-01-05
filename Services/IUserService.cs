using Entities;

namespace Services
{
    public interface IUserService
    {
        Task<User> createUser(User user);
        Task deleteUser(int id);
        Task<User> getById(int id);
        Task<List<User>> getUsers();
        Task<User> updateUser(int id, User userToUpdate);
        Task<User> login(string email, string password);

    }
}