using Contracts;
using Domain;
using System;
using System.Collections.Generic;
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

            return new UserModel
            {
                Id = user.Id,
                FirstName = user.Profile.FirstName,
                LastName = user.Profile.LastName,
                Email = user.Profile.Email,
                Login = user.Profile.Login
            };
        }
    }
}
