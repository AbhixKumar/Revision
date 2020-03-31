using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaBox.Storage.Database
{
    public class PizzaBoxDbContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Size> Size { get; set; }
        public DbSet<Crust> Crust { get; set; }
        public DbSet<Topping> Topping { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Store> Store { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("server=localhost;database=PizzaBoxDb;user id=sa;password=Password12345");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {            
            builder.Entity<Crust>().HasKey(c => c.CrustId);          
            builder.Entity<Size>().HasKey(s => s.SizeId);
            builder.Entity<Topping>().HasKey(t => t.ToppingId);
            builder.Entity<PizzaTopping>().HasKey(t => new { t.pizzaId, t.toppingId });   
            builder.Entity<PizzaOrder>().HasKey(po => new { po.OrderId, po.PizzaId }); 
            
            builder.Entity<Pizza>().HasKey(p => p.PizzaId);
            builder.Entity<Pizza>().Property(p => p.PizzaId).ValueGeneratedNever();
            
            
            builder.Entity<User>().HasKey(u => u.UserId);
            builder.Entity<User>().Property(p => p.UserId).ValueGeneratedNever();

            builder.Entity<Order>().HasKey(o => o.OrderId);
            builder.Entity<Order>().Property(p => p.OrderId).ValueGeneratedNever();

            builder.Entity<Store>().HasKey(s => s.StoreId);

            builder.Entity<Crust>().HasMany(c => c.Pizzas).WithOne(p => p.crust);
            builder.Entity<Size>().HasMany(s => s.Pizzas).WithOne(p => p.size);
            builder.Entity<PizzaTopping>().HasOne(pt => pt.Pizza).WithMany(p => p.PizzaTopping).HasForeignKey(pt => pt.pizzaId);
            builder.Entity<PizzaTopping>().HasOne(pt => pt.Topping).WithMany(t => t.PizzaTopping).HasForeignKey(pt => pt.toppingId);
            builder.Entity<PizzaOrder>().HasOne(po => po.Order).WithMany(p => p.PizzaOrder).HasForeignKey(po => po.OrderId);
            builder.Entity<PizzaOrder>().HasOne(po => po.Pizza).WithMany(o => o.PizzaOrders).HasForeignKey(po => po.PizzaId);

            builder.Entity<Crust>().HasData(new Crust[]
            {
            new Crust() { CrustId = 4 ,Name = "Deep Dish", Price = 3.50M },
            new Crust() { CrustId = 5 ,Name = "New York Style", Price = 2.50M },
            new Crust() { CrustId = 6, Name = "Thin Crust", Price = 1.50M }
             });

            builder.Entity<Size>().HasData(new Size[]
            {
            new Size() { SizeId = 4, Name = "Large", Price = 12.00M },
            new Size() { SizeId = 5, Name = "Medium", Price = 10.00M },
            new Size() { SizeId = 6, Name = "Small", Price = 8.00M },
            });

            builder.Entity<Topping>().HasData(new Topping[]
            {
            new Topping() { ToppingId = 4, Name = "Cheese", Price = 0.25M },
            new Topping() { ToppingId = 5, Name = "Pepperoni", Price = 0.50M },
            new Topping() { ToppingId = 6, Name = "Tomato Sauce", Price = 0.75M },
            });

            builder.Entity<Store>().HasData(new Store[]
            {
                new Store() { StoreId = 1, StoreLocation = "Location 1"},
                new Store() { StoreId = 2, StoreLocation = "Location 2"}
            });


        }
    }
}
