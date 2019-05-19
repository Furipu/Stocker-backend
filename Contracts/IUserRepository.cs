using Domain;
using Okta.Sdk;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        Task<List<IUser>> FindAll();
        Task<IUser> GetUserById(string id);
        void DeleteUser(string id);
        Task<string> CreateUser(UserModel userModel);
        void UpdateUser(UserModel userModel);
    }
}
