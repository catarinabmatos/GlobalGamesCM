using GlobalGamesCET50.data.entities;
using GlobalGamesCET50.Helpers;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.data
{
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private readonly Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmailAsync("diogo.machado18@gmail.com");
            if (user == null)
            {
                user = new User
                {
                    FirstName = "Catarina",
                    LastName = "Matos",
                    Email = "catarina.alforreca@gmail.com",
                    UserName = "catbm01",
                    PhoneNumber = "926478534",
                };

                var result = await this.userHelper.AddUserAsync(user, "5050");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create the user in seeder");
                }

            }


            if (!this.context.Inscricoes.Any())
            {
                this.AddInscricoes("Jorge Jesus", user); //mudar os nomes
                this.AddInscricoes("Rosa Cruz", user);
                this.AddInscricoes("Joana Silva", user);
                this.AddInscricoes("Pedro Carneiro", user);
                this.AddInscricoes("Rosália Esteves", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddInscricoes(string name, User user)
        {
            this.context.Inscricoes.Add(new Inscricoes
            {
                Nome = name,
                Apelido = name,
                CC = this.random.Next(30000000),
                User = user,
            });
        }
    }
}
