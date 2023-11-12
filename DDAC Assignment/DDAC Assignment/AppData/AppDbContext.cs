﻿using DDAC_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DDAC_Assignment.AppData
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        //属性名 = 表名
        public DbSet<Customer> sys_customer { get; set; }
    }
}