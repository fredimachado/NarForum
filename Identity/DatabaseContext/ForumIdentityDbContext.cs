﻿using Domain;
using Identity.Configurations;
using Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.DatabaseContext
{
    public class ForumIdentityDbContext: IdentityDbContext<ForumUser>
    {
        public ForumIdentityDbContext(DbContextOptions<ForumIdentityDbContext> options) : base(options)
        {

        }

        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ForumUser>(entity => { entity.ToTable(name: "Users"); });
            builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Roles"); });
            builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
            builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
            builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
            builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
            builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });


            builder.ApplyConfigurationsFromAssembly(typeof(ForumIdentityDbContext).Assembly);
        }
    }
}
