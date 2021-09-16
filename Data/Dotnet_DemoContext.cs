using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dotnet_Demo.Models;

    public class Dotnet_DemoContext : DbContext
    {
        public Dotnet_DemoContext (DbContextOptions<Dotnet_DemoContext> options)
            : base(options)
        {
        }

        public DbSet<Dotnet_Demo.Models.Movie> Movie { get; set; }

        public DbSet<Dotnet_Demo.Models.Student> Student { get; set; }

        public DbSet<Dotnet_Demo.Models.Person> Person { get; set; }
    }
