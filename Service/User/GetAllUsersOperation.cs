using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    public class GetAllUsersOperation
    {
        private readonly IUserRepository _repo;
        public GetAllUsersOperation(IUserRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<UserModel>> Execute()
        {
            var userModels = new List<UserModel>();
            var users = await _repo.FindAll();

            foreach (var user in users)
            {
                userModels.Add(new UserModel
                {
                    Id = user.Id,
                    FirstName = user.Profile.FirstName,
                    LastName = user.Profile.LastName,
                    Email = user.Profile.Email,
                    Login = user.Profile.Login
                });
            }

            return userModels;
        }
    }
}
