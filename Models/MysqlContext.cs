using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace TodoApi.Models
{
    public class MysqlContext : DbContext
    {
        public MysqlContext(DbContextOptions<MysqlContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<leads> leads { get; set; }
         public virtual DbSet<Batteries> batteries { get; set; }
    }
}