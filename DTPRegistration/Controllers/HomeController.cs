using DTPRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTPRegistration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DTPContext db = new DTPContext();
        public ActionResult Index()
        {
            // Отримуємо з БД всі об'єкти DTP 
            IEnumerable<DTPType> types = db.Types;
            // Передаємо всі  об'єкти в динамічну властивість DTPs в ViewBag 
            ViewBag.Types = types;
            // Повертаємо представлення 
            return View();
        }
        [HttpGet]
        public ActionResult Reg(int id)
        {
            ViewBag.TypeId = id;
            return View();
        }
        [HttpPost]
        public string Reg(DTPRegistr dtpregister)
        {
            dtpregister.Date_Por = DateTime.Now;
            // Додаємо інформацію про Реєстрацію ДТП в базу даних 
            db.Registrations.Add(dtpregister);
            //  Зберігаємо в БД всі зміни 
            db.SaveChanges();
            return "Дорожньо-транспортна пригода зареєстрована в базі даних!";
        }
    }
}