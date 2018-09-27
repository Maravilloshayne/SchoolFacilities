using Microsoft.EntityFrameworkCore;
using ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;

namespace ShaneMaravillo.SchoolFacilities.Web.Infrastructures.Data.Helpers
{
    public class DefaultDbContext : DbContext
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options)
   : base(options)
        {
        }
        #region Models
        public DbSet<Post> Posts { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}