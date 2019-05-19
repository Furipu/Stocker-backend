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

        
        public async Task<List<IUser>> FindAll()
        {
            var client = new OktaClient(new OktaClientConfiguration
            {
                OktaDomain = "https://dev-674202.okta.com",
                Token = "0073ScrmhS0OvUaaPJdJxlUPRhlYZ110ftuuZQAZpf"
            });

            var allUsers =  await client.Users.ListUsers().ToList();

            return allUsers;
        }

        public async Task<IUser> GetUserById(string id)
        {
            var users = await FindAll();

            return users.FirstOrDefault(x => x.Id == id);
        }

        public async void DeleteUser(string id)
        {
            var user = await GetUserById(id);

            await user.DeactivateAsync();
            await user.DeactivateOrDeleteAsync();
        }

        public async Task<string> CreateUser(UserModel userModel)
        {
            var client = new OktaClient(new OktaClientConfiguration
            {
                OktaDomain = "https://dev-674202.okta.com",
                Token = "0073ScrmhS0OvUaaPJdJxlUPRhlYZ110ftuuZQAZpf"
            });

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

            return newUser.Id;
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
      
    }
}
