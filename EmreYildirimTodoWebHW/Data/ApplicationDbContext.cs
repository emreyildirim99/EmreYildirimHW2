﻿using System;
using System.Collections.Generic;
using System.Text;
using EmreYildirimTodoWebHW.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmreYildirimTodoWebHW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}