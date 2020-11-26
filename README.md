Arkadaşlar merhaba,  

Web sayfası kodlamaya başlayan herkesin en temel ihtiyaçlarından birisi hiç kuşkusuz sonsuz seviyeli menülerdir.Hangi seviyede, hangi bilgi birikiminde olursa olsun web sayfası geliştirme yapan bütün yazılımcıların temel ihtiyacı olan bu konuya bende basit ve anlaşılır bir çözüm getirmek istedim. 

 İlk olarak Platform olarak Visual Studio üzerinden Asp.net MVC 6.0'ı kullandığımı belirtmek istiyorum.Visual Studio u açıp boş bir Asp.NET MVC projesi başlatıyorum ve ilk olarak hemen Model klasörüne menü isimli bir class tanımlıyorum.Veri tabanı bağlantısı yaparak örneği uzatmak istemediğim için direk oluşturduğum bu modeli Controller üzerinde List şekline doldurarak kullanacağım.Böylelikle sizde örnek olarak paylaşacağım kodları indirdiğinizde direk örneğin çalışır haline ulaşabileceksiniz. 

 Menu isimli olarak tanımladığım class a aşağıdaki gibi property ler ekliyorum.


public class Menu
    {
        public int id { get; set; }
        public int? menuId { get; set; }
        public string Adi { get; set; }
        public string Açiklama { get; set; }
    }

Menu class ını yaratıktan sonra Controller klasörüne sağ tıklayarak Home isimli yeni bir Controller ekliyorum. Eklemiş olduğum Home isimli Controller'ımın içerisini de aşağıdaki gibi kodluyorum.


 public class HomeController : Controller
    {
        List<Menu> _MenuListesi;
        public HomeController()
        {
            _MenuListesi = new List< Menu>();

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
            menu2_1_1.Açiklama = ".Net İsimli Alt Elemanının C# isimli Alt Elemanı";

            _MenuListesi.Add(menu2_1_1);


            Menu menu2_1_2 = new Menu();
            menu2_1_2.id = 212;
            menu2_1_2.menuId = 21;
            menu2_1_2.Adi = ".Net Core";
            menu2_1_2.Açiklama = ".Net İsimli Alt Elemanının .Net Core isimli Alt Elemanı";

            _MenuListesi.Add(menu2_1_2);

            Menu menu2_1_2_1 = new Menu();
            menu2_1_2_1.id = 2121;
            menu2_1_2_1.menuId = 212;
            menu2_1_2_1.Adi = "Asp.Net Core MVC";
            menu2_1_2_1.Açiklama = ".Net Core isimli Alt Elemanının Asp.Net Core MVC İsimli Alt Elemanı";

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

Model klasörünün içerisine yarattığımız Menu isimli class!ıda List şeklinde doldurup View a bir model olarak gönderiyorum.  

HomeController açıkken Index isimli olarak yazılmış ActionResult'a sağ tık ile tıklayıp Add View a tıklayarak Index isimli bir view yaratıyorum. View'ı yaratırken herhangi bir Layout seçmiyorum ki oluşturduğumuz View ekrana kendi Html tagleri ile gelsin. 
 Sonsuz seviyeli menümüzün ekranımızı çalıştırdığımızda düzgün görünmesi için aşağıdaki gibi bir css yapısı kullandım. Sizde paylaştığım css leri sayfanızın tagleri arasına ekleyebilirsiniz.

<style type="text/css">
        #navcss {
            margin: 0;
            padding: 7px 6px 0;
            background: #7d7d7d url(gradient.png) repeat-x 0 -110px;
            line-height: 100%;
            border-radius: 1em;
            -webkit-border-radius: 1em;
            -moz-border-radius: 1em;
            -webkit-box-shadow: 0 1px 3px rgba(0,0,0, .4);
            -moz-box-shadow: 0 1px 3px rgba(0,0,0, .4);
        }

        #nav li {
            margin: 0 5px;
            padding: 0 0 8px;
            float: left;
            position: relative;
            list-style: none;
        }


        #nav a {
            font-weight: bold;
            font-size: 16px;
            color: #444;
            text-decoration: none;
            display: block;
            padding: 8px 20px;
            margin: 0;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            text-shadow: 0 1px 1px rgba(0,0,0, .3);
        }

            #nav a:hover {
                background: #000;
                color: #fff;
            }


        #nav .current a, #nav li:hover > a {
            background: #666 url(gradient.png) repeat-x 0 -40px;
            color: #444;
            border-top: solid 1px #f8f8f8;
            -webkit-box-shadow: 0 1px 1px rgba(0,0,0, .2);
            -moz-box-shadow: 0 1px 1px rgba(0,0,0, .2);
            box-shadow: 0 1px 1px rgba(0,0,0, .2);
            text-shadow: 0 1px 0 rgba(255,255,255, 1);
        }


        #nav li:active > a {
            background: #666 url(gradient.png) repeat-x 0 -40px;
            color: #444;
            border-top: solid 1px #f8f8f8;
            -webkit-box-shadow: 0 1px 1px rgba(0,0,0, .2);
            -moz-box-shadow: 0 1px 1px rgba(0,0,0, .2);
            box-shadow: 0 3px 3px rgba(255,255,255, 1);
            text-shadow: 0 1px 0 rgba(255,255,255, 1);
        }


        #nav ul li:hover a, #nav li:hover li a {
            background: none;
            border: none;
            color: #666;
            -webkit-box-shadow: none;
            -moz-box-shadow: none;
        }

        #nav ul a:hover {
            background: #0078ff url(gradient.png) repeat-x 0 -100px !important;
            color: #fff !important;
            -webkit-border-radius: 0;
            -moz-border-radius: 0;
            text-shadow: 0 1px 1px rgba(0,0,0, .1);
        }

        #nav li:hover > ul {
            display: block;
        }


        #nav ul {
            display: none;
            margin: 0;
            padding: 0;
            width: 185px;
            position: absolute;
            top: 35px;
            left: 0;
            background: #ddd url(gradient.png) repeat-x 0 0;
            border: solid 1px #b4b4b4;
            -webkit-border-radius: 5px;
            -moz-border-radius: 5px;
            border-radius: 5px;
            -webkit-box-shadow: 0 1px 3px rgba(0,0,0, .3);
            -moz-box-shadow: 0 1px 3px rgba(0,0,0, .3);
            box-shadow: 0 1px 3px rgba(0,0,0, .3);
        }

            #nav ul li {
                float: none;
                margin: 0;
                padding: 0;
            }

            #nav ul a {
                font-weight: normal;
                text-shadow: 0 1px 0 #fff;
            }


            #nav ul ul {
                left: 181px;
                top: -3px;
            }


            #nav ul li:first-child > a {
                -webkit-border-top-left-radius: 4px;
                -moz-border-radius-topleft: 4px;
                -webkit-border-top-right-radius: 4px;
                -moz-border-radius-topright: 4px;
            }

            #nav ul li:last-child > a {
                -webkit-border-bottom-left-radius: 4px;
                -moz-border-radius-bottomleft: 4px;
                -webkit-border-bottom-right-radius: 4px;
                -moz-border-radius-bottomright: 4px;
            }
    </style>
	
	
CSS lerimizide hallettikten sonra artık sayfamızı istediğimiz sonsuz seviyeli menü için hazırlamış durumdayız. Şimdi artık Index.cshtml sayfamızın en başında bir helper yaratıyoruz. Bu helper'ı kendi kendini tekrar eden bir recursive metod olarak kodluyoruz. Böylelikle parametre olarak verilen ana menü id'sine göre bütün alt menüleri getirecektir. Yazmış olduğumuz Helper aşağıda paylaşıyorum sizde alıp istediğiniz gibi değişiklik yaparak kullanabilisiniz.


@helper MenuOlustur(List<Menu> menu, int? menuid)
{
    foreach (var i in menu.Where(a => a.menuId.Equals(menuid)))
    {
        <li>
            @{var submenu = menu.Where(a => a.menuId.Equals(i.id)).Count();}

                < a href="@i.id">@i.Adi

            @if (submenu > 0)
            {
                <ul>
                    @MenuOlustur(menu, i.id)
                </ul>
            }
        </li>
    }
}


Bu arada unutmadan Controller da List şeklinde hazırladığımız menümüzü Index sayfamıza model olarak gönderiyoruz ve Index.cshtml sayfamızda modelimizi aşağıdaki gibi sayfa modeli olarak kullanıyoruz.

 @model List<Menu> 

Böylelikle ekranımıza getirdiğimiz bu modeli yukarıda hazırladığımız helper'ımıza vererek Controller da doldurduğumuz menümüzü ekranımızda gösterebiliriz.
Herşeyimiz hazır olduğuna göre artık son olarak hazıraldığımız helper a modelimizi vererek Index.cshtml sayfamızda html tagleri arasında istediğimiz yerde kullanabiliriz. Örnek kullanımı aşağıdaki gibidir.


<body>
   
    @if (Model != null && Model.Count() > 0)
    {
        <ul id="nav">
            @MenuOlustur(Model, Model.FirstOrDefault().menuId)
        </ul>
    }

</body>

Projemizi artık derletip çalıştırdığımızda karşımıza asonsuz seviyeli bir menü örneği çıkacaktır.
