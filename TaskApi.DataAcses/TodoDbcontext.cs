using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.DataAcses
{
    public class TodoDbcontext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=DESKTOP-CNC0FHC;Database=MyTodoNew;Trusted_Connection=True;MultipleActiveResultSets=true;";
            
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[] 
            {

                new Author
                {
                    id=1,
                    FullName="kaveesha",
                    AddrssNo ="50",
                    street = "street 1",
                    city = "Colombo 1",
                    jobRole = "Developer"
                    
                },

                new Author
                {
                    id=2,
                    FullName="Thathsara",
                     AddrssNo ="60",
                    street = "street 2",
                    city = "Colombo 2",
                    jobRole = "System Engineer"
                },

                new Author
                {
                    id=3,
                    FullName="Sandaru",
                    AddrssNo ="70",
                    street = "street 3",
                    city = "Colombo 3",
                    jobRole = "Developer"
                },

                new Author
                {

                    id=4,
                    FullName="Nimesh",
                    AddrssNo ="80",
                    street = "street 4",
                    city = "Colombo 4",
                    jobRole = "QA"

                }

            });
            modelBuilder.Entity<Todo>().HasData(new Todo[] 
            {
             new Todo
             {
                id = 1,
                title = "Gets book new from SQl",
                description = "Get books fro the School new",
                create =  DateTime.Now,
                due = DateTime.Now.AddDays(5),
                ststus = TodoStatus.New,
                Authorid = 1
             },

             new Todo
             {
                 id = 2,
                title = "Get car parts new from Sql",
                description = "Get spare arts for vehichel new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(4),
                ststus = TodoStatus.New,
                Authorid =1
             },

             new Todo
             {
              id = 3,
                title = "Get Food New from Sql",
                description = "Get foods for the week new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(3),
                ststus = TodoStatus.New,
                Authorid = 2
             },

            
             new Todo
             {
                id = 4,
                title = "Get Medicine new from Sql",
                description = "Get medicine Hosptiale new",
                create = DateTime.Now,
                due = DateTime.Now.AddDays(1),
                ststus = TodoStatus.New,
                Authorid = 3
             }

            });
        }
    }
}
