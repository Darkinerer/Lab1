using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Лаб1_Веб.Models
{
    public class Purchase
    { // ID покупки
        public int PurchaseId { get; set; }
        // ім’я і прізвище покупця
        public string Person { get; set; }
        // адреса покупця
        public string Address { get; set; }
        // ID покупки
        public int ItemId { get; set; }
        // дата покупки
        public DateTime Date { get; set; }
    }
}