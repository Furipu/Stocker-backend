using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
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
                var userGroup = await user.Groups.ToList();

                var newUserModel = new UserModel
                {
                    Id = user.Id,
                    FirstName = user.Profile.FirstName,
                    LastName = user.Profile.LastName,
                    Email = user.Profile.Email,
                    Login = user.Profile.Login,
                    Roles = new List<string>()
                };

            foreach (var group in userGroup)
            {
                newUserModel.Roles.Add(group.Profile.Name);
            }

            userModels.Add(newUserModel);
            }

            return userModels;
        }
    }
}
