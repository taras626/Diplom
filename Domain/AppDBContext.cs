using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TsukanovaDesign.Domain.Entites;

namespace TsukanovaDesign.Domain
{
    public class AppDBContext : IdentityDbContext<IdentityUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {}

        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<ObjectOfPortfolio> ObjectsOfPortfolio { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<HelperQuestion> HelperQuestions { get; set; }
        public DbSet<QuestionAnswersConnector> QuestionAnswersConnectors { get; set; }
        public DbSet<HelperAnswer> HelperAnswers { get; set; }
        public DbSet<HelperAdvice> HelperAdvices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuestionAnswersConnector>().HasNoKey();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "a55379a6-87f9-4518-b1c0-685eee42c752",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "ca571133-52b2-4d7e-9969-544200f8d7b1",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "email@mail.ru",
                NormalizedEmail = "EMAIL@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a55379a6-87f9-4518-b1c0-685eee42c752",
                UserId = "ca571133-52b2-4d7e-9969-544200f8d7b1"
            });
        }
    }
}
