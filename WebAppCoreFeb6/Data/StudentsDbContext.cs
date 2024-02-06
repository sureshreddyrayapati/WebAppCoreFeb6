using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppCoreFeb6.Models;

namespace WebAppCoreFeb6.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext (DbContextOptions<StudentsDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppCoreFeb6.Models.Student> Student { get; set; } = default!;
    }
}
