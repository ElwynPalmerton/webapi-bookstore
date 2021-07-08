using System.Collections.Generic;
using BookstoreAPI.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;


namespace BookstoreAPI.Data
{

    public class BookstoreContext : DbContext
    {
        public BookstoreContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Book> Books {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Thing on the Train", Author = "Hawkins, Paula", PublicationYear = 2015, CallNumber = "F HAWKI"},
                new Book { Id = 2, Title = "Handsome Lawyer", Author = "Grisham, John", PublicationYear = 2015, CallNumber = "F GRISH"},
                new Book { Id = 3, Title = "After Them", Author = "Moyes, Jojo", PublicationYear = 2015, CallNumber = "F MOYES"},
                new Book { Id = 4, Title = "All the Softness We Cannot See", Author = "Doerr, Anthony", PublicationYear = 2014, CallNumber = "F DOERR"},
                new Book { Id = 5, Title = "Girls III", Author = "Cline, Emma", PublicationYear = 2016, CallNumber = "F CLINE"},
                new Book { Id = 6, Title = "The Martian II", Author = "Weir, Andy", PublicationYear = 2011, CallNumber = "SF WEIR"},
                new Book { Id = 7, Title = "Me Before You", Author = "Moyes, Jojo", PublicationYear = 2012, CallNumber = "F MOYES"},
                new Book { Id = 8, Title = "Alexander Hamilton", Author = "Chernow, Ron", PublicationYear = 2004, CallNumber = "B HAMILTO A"},
                new Book { Id = 9, Title = "Before the Fall", Author = "Hawley, Noah", PublicationYear = 2016, CallNumber = "F HAWLE"}
            );

        }
    }
}