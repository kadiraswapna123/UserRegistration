using Microsoft.EntityFrameworkCore;
using RepositryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositryLayer.Context
{
    public class FundooContext : DbContext
    {
        public FundooContext(DbContextOptions options)
          : base(options)
        {
        }
        public DbSet<UserEntity> UserTable { get; set; }
    }
}
