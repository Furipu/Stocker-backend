using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    class DeleteUserOPeration
    {
        private readonly IUserRepository _repo;
        public DeleteUserOPeration(IUserRepository repo)
        {
            _repo = repo;
        }

        public async void Execute(string id)
        {
            var user = await _repo.GetUserById(id);

            // First, deactivate the user
            await user.DeactivateAsync();

            // Then delete the user
            await user.DeactivateOrDeleteAsync();
            
        }
    }
}
