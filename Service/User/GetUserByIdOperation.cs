using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    class GetUserByIdOperation
    {
        private readonly IUserRepository _repo;
        public GetUserByIdOperation(IUserRepository repo)
        {
            _repo = repo;
        }
        public async Task<UserModel> Execute(string id)
        {

            var user = await _repo.GetUserById(id);
            var userGroup = await user.Groups.ToList();

            var userModel = new UserModel
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
                userModel.Roles.Add(group.Profile.Name);
            }

            return userModel;
        }
    }
}
