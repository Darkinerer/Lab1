using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Лаб1_Веб.Models
{
    public class GoodsContext : DbContext
    {

        public DbSet<Goods> Goods { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}