﻿using Microsoft.EntityFrameworkCore;

namespace EFCore.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
