using HastaneInfo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneInfo.DataAccess.Concrete.EntityFramework
{
    public class HastaneDbContext : DbContext
    {
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Polyclinic> Policlinics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
