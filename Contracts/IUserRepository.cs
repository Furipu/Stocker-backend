using Domain;
using Okta.Sdk;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<List<IUser>> FindAll();
        Task<IUser> GetUserById(string id);
        Task<IUser> GetUserByEmail(string email);
        void DeleteUser(string id);
        void CreateUser(UserModel userModel);
        void UpdateUser(UserModel userModel);
        void AddRoleToUser(string roleId, Task<IUser> userId);
    }
}
