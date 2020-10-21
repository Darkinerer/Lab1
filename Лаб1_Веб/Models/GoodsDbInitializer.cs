using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Лаб1_Веб.Models
{
    public class GoodsDbInitializer : DropCreateDatabaseAlways<GoodsContext>
    {
       
            protected override void Seed(GoodsContext db)
            {
                db.Goods.Add(new Goods              {
                    Name = "Ігрова консоль",
                    Maker = "Sony", Price = 9000 });
                db.Goods.Add(new Goods
                {
                    Name = "Мобільний телефон",   Maker = "Huaway", Price = 7000 });
                    
                db.Goods.Add(new Goods
                {
                    Name = "Навушники",
                    Maker = "Razor",
                    Price = 1000
                });
                base.Seed(db);
            }
        
    }
}