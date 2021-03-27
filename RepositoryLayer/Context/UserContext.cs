using CommonLayer.ResponseModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
    public class UserContext : DbContext
    {
       
        public UserContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
