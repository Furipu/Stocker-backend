using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    class SaveUserOperation
    {
        private readonly IUserRepository _repo;
        public SaveUserOperation(IUserRepository repo)
        {
            _repo = repo;
        }

        public void Execute(UserModel userModel)
        {
            userModel.Password = "Stocker123";
            _repo.CreateUser(userModel);

            var user = _repo.GetUserByEmail(userModel.Email);
            

            if (user != null)
            {
                foreach (var role in userModel.Roles)
                {
                    _repo.AddRoleToUser(role, user);
                }
            }
        }
    }
}
