using Contracts;
using Domain;
using Okta.Sdk;
using Okta.Sdk.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : IUserRepository
    {
        private OktaClient getClient()
        {
            return new OktaClient(new OktaClientConfiguration
            {
                OktaDomain = "https://dev-674202.okta.com",
                Token = "0073ScrmhS0OvUaaPJdJxlUPRhlYZ110ftuuZQAZpf"
            });
        }

        public async Task<List<IUser>> FindAll()
        {
            var client = getClient();

            var allUsers = await client.Users.ListUsers().ToList();

            return allUsers;
        }

        public async Task<IUser> GetUserById(string id)
        {
            var users = await FindAll();

            return users.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IUser> GetUserByEmail(string email)
        {
            var users = await FindAll();

            return users.FirstOrDefault(us => us.Profile.Email == email);
        }
        public async void DeleteUser(string id)
        {
            var user = await GetUserById(id);

            await user.DeactivateAsync();
            await user.DeactivateOrDeleteAsync();
        }

        public async void CreateUser(UserModel userModel)
        {
            var client = getClient();

            var newUser = await client.Users.CreateUserAsync(new CreateUserWithPasswordOptions
            {
                // User profile object
                Profile = new UserProfile
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    Email = userModel.Email,
                    Login = userModel.Login,
                },
                Password = userModel.Password,
                Activate = false,
            });

            await newUser.ActivateAsync();


        }

        public async void UpdateUser(UserModel userModel)
        {

            var user = await GetUserById(userModel.Id);

            user.Profile.FirstName = userModel.FirstName;
            user.Profile.LastName = userModel.LastName;
            user.Profile.Email = userModel.Email;
            user.Profile.Login = userModel.Login;

            await user.UpdateAsync();
        }

        public async void UpdateRoleToUser(List<string> roles, Task<IUser> user, bool isUpdate)
        {
            var client = getClient();
            var checkUser = await client.Users.FirstOrDefault(x => x.Profile.Email == user.Result.Profile.Email);

            var groups = await checkUser.Groups.ToList();

            foreach (var role in roles)
            {
                var checkGroups = groups.FirstOrDefault(grs => grs.Profile.Name == role);

                if (checkGroups == null)
                {
                    var group = await client.Groups.FirstOrDefault(x => x.Profile.Name == role);
                    await client.Groups.AddUserToGroupAsync(group.Id, user.Result.Id);
                }
            }

            if (isUpdate)
            {
                foreach (var group in groups)
                {
                    var checkRole = roles.FirstOrDefault(rol => rol == group.Profile.Name);

                    if (checkRole == null)
                    {
                        var role = await client.Groups.FirstOrDefault(x => x.Profile.Name == group.Profile.Name);
                        await client.Groups.RemoveGroupUserAsync(group.Id, user.Result.Id);
                    }
                }
            }

        }

    }
}
