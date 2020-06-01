using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TRPO_Kurs.Models
{
    public class EquipmentContext: DbContext // БД
    {
        public DbSet<Equipment> Equipments { get; set; } //Таблицы
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}