using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolSystem.Models.Entities;

namespace SchoolSystem.Persistence
{
   public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext(DbContextOptions<SchoolSystemContext>opt)
                                 :base(opt)
        {

        }
        public DbSet<User> users{get;set;}
    }
}
