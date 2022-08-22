using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
               new Employee
               {
                   Id = 1,
                   Name = "Kickstart",
                   Department = Dept.CTO,
                   Email = "best@kickstart.com"
               },
                   new Employee
                   {
                       Id = 2,
                       Name = "Idowu",
                       Department = Dept.CTO,
                       Email = "idowu@best.com"
                   }
               );
        }
    }
}
