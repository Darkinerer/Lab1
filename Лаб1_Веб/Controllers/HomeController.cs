using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Лаб1_Веб.Models;

namespace Лаб1_Веб.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
       
            GoodsContext db = new GoodsContext();
            public ActionResult Index()
            {
                // Отримуємо з БД всі об'єкти Book
                IEnumerable<Goods> goods = db.Goods;
                // Передаємо всі об'єкти в динамічну властивість Books в ViewBag
                ViewBag.Goods = goods;
           // Повертаємо представлення
        return View();
            }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.GoodsId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // Додаємо інформацію про покупку в базу даних
            db.Purchases.Add(purchase);
            // Зберігаємо в БД всі зміни
            db.SaveChanges();
            return "Спасибі," + purchase.Person + ", за покупку!";
        }


    }
}