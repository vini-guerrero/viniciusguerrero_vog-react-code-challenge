using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VogCodeChallenge.Data.Entities;

namespace VogCodeChallenge.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
        }

        public DbSet<DepartmentEntity> Department { get; set; }

        public DbSet<EmployeeEntity> Employee { get; set; }
    }
}