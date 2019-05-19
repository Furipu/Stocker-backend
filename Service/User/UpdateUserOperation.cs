using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    public class UpdateUserOperation
    {
        private readonly IUserRepository _repo;
        public UpdateUserOperation(IUserRepository repo)
        {
            _repo = repo;
        }

        public void Execute(UserModel userModel)
        {
            _repo.UpdateUser(userModel);
        }
    }
}
