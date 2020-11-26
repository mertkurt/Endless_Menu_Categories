using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        List<Menu> _MenuListesi;
        public HomeController()
        {
            _MenuListesi = new List<Menu>();

            Menu menu1 = new Menu();
            menu1.id = 1;
            menu1.menuId = null;
            menu1.Adi = "Anasayfa";
            menu1.Açiklama = "AnaSayfa İsimli Ana Menü Elemanı";

            _MenuListesi.Add(menu1);


            Menu menu2 = new Menu();
            menu2.id = 2;
            menu2.menuId = null;
            menu2.Adi = "Programlama";
            menu2.Açiklama = "Programlama İsimli Ana Menü Elemanı";

            _MenuListesi.Add(menu2);

            Menu menu2_1 = new Menu();
            menu2_1.id = 21;
            menu2_1.menuId = 2;
            menu2_1.Adi = ".Net";
            menu2_1.Açiklama = "Programlama İsimli Ana Menü Elemanının .Net İsimli Alt Elemanı";

            _MenuListesi.Add(menu2_1);

            Menu menu2_1_1 = new Menu();
            menu2_1_1.id = 211;
            menu2_1_1.menuId = 21;
            menu2_1_1.Adi = "C#";
            menu2_1_1.Açiklama = "Programlama İsimli Ana Menü Elemanının .Net İsimli Alt Elemanının C# isimli Alt Elemanı";

            _MenuListesi.Add(menu2_1_1);


            Menu menu2_1_2 = new Menu();
            menu2_1_2.id = 212;
            menu2_1_2.menuId = 21;
            menu2_1_2.Adi = ".Net Core";
            menu2_1_2.Açiklama = "Programlama İsimli Ana Menü Elemanının .Net İsimli Alt Elemanının .Net Core isimli Alt Elemanı";

            _MenuListesi.Add(menu2_1_2);

            Menu menu2_1_2_1 = new Menu();
            menu2_1_2_1.id = 2121;
            menu2_1_2_1.menuId = 212;
            menu2_1_2_1.Adi = "Asp.Net Core MVC";
            menu2_1_2_1.Açiklama = "Programlama İsimli Ana Menü Elemanının .Net İsimli Alt Elemanının .Net Core isimli Alt Elemanının Asp.Net Core MVC İsimli Alt Elemanı";

            _MenuListesi.Add(menu2_1_2_1);

            Menu menu2_2 = new Menu();
            menu2_2.id = 22;
            menu2_2.menuId = 2;
            menu2_2.Adi = "Java";
            menu2_2.Açiklama = "Programlama İsimli Ana Menü Elemanının Alt Elemanı";

            _MenuListesi.Add(menu2_2);


            Menu menu3 = new Menu();
            menu3.id = 3;
            menu3.menuId = null;
            menu3.Adi = "Hakkımızda";
            menu3.Açiklama = "Hakkımızda İsimli Ana Menü Elemanı";

            _MenuListesi.Add(menu3);

            Menu menu4 = new Menu();
            menu4.id = 4;
            menu4.menuId = null;
            menu4.Adi = "İletişim";
            menu4.Açiklama = "İletişim İsimli Ana Menü Elemanı";

            _MenuListesi.Add(menu4);

        }
        public ActionResult Index()
        {
            return View(_MenuListesi.ToList());
        }

    }
}
