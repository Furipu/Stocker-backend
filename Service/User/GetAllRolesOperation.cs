using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    class GetAllRolesOperation
    {
        private readonly IUserRepository _repo;
        public GetAllRolesOperation(IUserRepository repo)
        {
            _repo = repo;
        }
        public async Task<List<string>> Execute()
        {
            var allUsers = await _repo.FindAll();
            var listWithGroups = new List<string>();

            foreach (var user in allUsers)
            {
                var groups = await user.Groups.ToList();

                foreach (var group in groups)
                {
                    var result = listWithGroups.FirstOrDefault(lwg => lwg == group.Profile.Name);

                    if (result == null)
                    {
                        listWithGroups.Add(group.Profile.Name);
                    }
                }

            }

            return listWithGroups;
        }
    }
}
