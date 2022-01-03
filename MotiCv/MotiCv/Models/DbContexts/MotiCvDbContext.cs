using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MotiCv.Models.Entities;
using MotiCv.Models.Entities.Membership;
using MotiCv.Models.Entitys;

namespace MotiCv.Models.DbContexts
{
    public class MotiCvDbContext : IdentityDbContext<MotiUser, MotiRole, int, MotiUserClaim, MotiUserRole, MotiUserLogin, MotiRoleClaim, MotiUserToken>
    { 
        public MotiCvDbContext()
            : base()
        {
        }
        public MotiCvDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MotiUser>(e=> {
                e.ToTable("MotiUsers","Membership");
            });
            builder.Entity<MotiRole>(e=> {
                e.ToTable("MotiRoles", "Membership");
            });
            builder.Entity<MotiUserClaim>(e=> {
                e.ToTable("MotiUserClaims", "Membership");
            });
            builder.Entity<MotiRoleClaim>(e=> {
                e.ToTable("MotiRoleClaims", "Membership");
            });
            builder.Entity<MotiUserRole>(e=> {
                e.ToTable("MotiUserRoles", "Membership");
            });
            builder.Entity<MotiUserLogin>(e=> {
                e.ToTable("MotiUserLogins", "Membership");
            });
            builder.Entity<MotiUserToken>(e=> {
                e.ToTable("MotiUserTokens", "Membership");
            });
        }
        public DbSet<My> MyData { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ContactPost> ContactPosts { get; set; }
        public DbSet<LocationContact> LocationContacts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
