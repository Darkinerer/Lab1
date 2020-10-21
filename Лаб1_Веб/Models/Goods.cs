using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Лаб1_Веб.Models
{
    public class Goods
    {
        // ID 
        public int Id { get; set; }
        // назва 
        public string Name { get; set; }
        // виробник
        public string Maker { get; set; }
        // ціна
        public int Price { get; set; }
    }
}
