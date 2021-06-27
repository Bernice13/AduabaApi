using AduabaApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AduabaApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> opt):base(opt)
        {

        }

        
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentCard> PaymentCards { get; set; }
        public DbSet<WishListItems> WishLists { get; set; }
        public DbSet<CartItem> ShoppingCarts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        




    }
}
