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

        public async void Execute(UserModel userModel)
        {
            userModel.Password = "Stocker123";
            _repo.CreateUser(userModel);            
        }
    }
}
