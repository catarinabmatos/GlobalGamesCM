using GlobalGamesCET50.data.entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlobalGamesCET50.data
{
    public class DataContext : IdentityDbContext <User>
    {

        public DbSet<Servicos> Servicos { get; set; }

        public DbSet<Inscricoes> Inscricoes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


    }
}
 