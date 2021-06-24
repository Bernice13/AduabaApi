using AduabaApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AduabaApp.Data
{
    public class AduabaDbContext:DbContext
    {
        public AduabaDbContext(DbContextOptions<AduabaDbContext> opt):base(opt)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }



    }
}
