using GlobalGamesCET50.data.entities;
using GlobalGamesCET50.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.Helpers
{
    public interface IUserHelper
    {

        Task<User> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

        Task<SignInResult> LoginInAsync(LoginViewModel model);


        Task LogoutAync();

    }
}
