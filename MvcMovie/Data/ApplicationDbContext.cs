using System;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Models.Entities;
namespace MvcMovie.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Student { get; set;}
        public DbSet<Version> Person { get; set;}

    }
}