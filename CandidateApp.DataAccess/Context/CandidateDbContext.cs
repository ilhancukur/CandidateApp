using CandidateApp.Domain.Entities;
using CandidateApp.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateApp.DataAccess.Context
{
    public class CandidateDbContext : DbContext
    {
        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction>  Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(

                new Customer {  Id=1, Name="ilhan", Surname = "Çukur", IdentityNo =11111111111,BirthDate= DateTime.Now, IdentityNoVerified="",Status=0 }

                );

            modelBuilder.Entity<Transaction>().HasData(

                new Transaction { Id = 1, CustomerId=1,OrderId="0",Amount=1234,CardPan="1234567891234567", Types = "Auth",ResponseCode="00",ResponseMesssage="",Status="0" }

                );
        }

    }

}

