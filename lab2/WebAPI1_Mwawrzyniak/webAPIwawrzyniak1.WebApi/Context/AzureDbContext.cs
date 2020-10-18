using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webAPIwawrzyniak1.WebApi.Models;

namespace webAPIwawrzyniak1.WebApi.Context
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options) : base(options)
        {
        }

        protected AzureDbContext()
        {
        }

        public DbSet<Person> People { get; set; }
    }
}
