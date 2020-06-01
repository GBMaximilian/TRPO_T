using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRPO_Kurs.Models;

namespace TRPO_Kurs.Controllers
{

    public class HomeController : Controller
    {
        private EquipmentContext equipmentContext = new EquipmentContext();

        public ActionResult Index()
        {
            IEnumerable<Category> categories = equipmentContext.Categories;
            ViewBag.Categories = categories; //дин свойтсво
            return View();
        }

        [HttpGet]
        public ActionResult Products(int id)
        {
            ViewBag.Id = id;
            IEnumerable<Category> categories = equipmentContext.Categories;
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Categories = categories; //дин свойтсво
            ViewBag.Equipments = equipments;
            return View();
        }


        [HttpGet]
        public ActionResult MyProduct(int id)
        {
            ViewBag.Id = id;
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Equipments = equipments;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page";

            return View();
        }
        [HttpGet]
        public ActionResult Order(int id)
        {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public string Order(Order order)
        {
            order.DataTime = DateTime.Now;
            equipmentContext.Orders.Add(order);

            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Equipments = equipments;

            equipmentContext.SaveChanges();
            string outstr = "Заказ прошел успешно!" + "\n" + "С Вами скоро свяжутся!";
            return outstr;
        }
        string adminPassword = "0000";
        public ActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        private ActionResult Admin(string password)
        {
            ViewBag.password = password;
            return View();
        }

        public ActionResult Password_Result(string password = null)
        {
             {
                if (password == adminPassword) ViewBag.wrongpas = adminPassword;
                    else if (password != null) ViewBag.wrongpas = "Неверный пароль";
                    else ViewBag.wrongpas = "Введите пароль администратора";
                    return View("PasswordResult");
            }
        }

        public ActionResult Search()
        {
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Equipments = equipments;
            return View();
        }

        [HttpPost]
        public ActionResult Search(string filter)
        {
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Equipments = equipments;
            ViewBag.filter = filter;
            return View();
        }

        public ActionResult DoSearch(string filter = null)
        {
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            List<Equipment> searchEquipment = new List<Equipment>();
            if (filter != null)
            {
                foreach (var eq in equipments)
                {
                    if ((eq.Name.ToLower().Contains(filter.ToLower()))) searchEquipment.Add(eq);
                }
            }
            ViewBag.searchEquipment = searchEquipment;
            return View("Display_Search", searchEquipment);
        }

        public ActionResult Articles()
        {
            ViewBag.Message = "Тут будут статьи";
            IEnumerable<Category> categories = equipmentContext.Categories;
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;

            ViewBag.Categories = categories;
            ViewBag.Equipments = equipments;


            return View();
        }

        [HttpGet]
        public ActionResult CaregoryRedaction(string password)
        {
            ViewBag.Password = password;
            IEnumerable<Category> categories = equipmentContext.Categories;
            IEnumerable<Equipment> equipments = equipmentContext.Equipments;
            ViewBag.Categories = categories; //дин свойтсво
            ViewBag.Equipments = equipments;
            return View();
        }
    }
}