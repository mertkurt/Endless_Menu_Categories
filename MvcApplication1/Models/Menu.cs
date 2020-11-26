using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Menu
    {
        public int id { get; set; }
        public int? menuId { get; set; }
        public string Adi { get; set; }
        public string Açiklama { get; set; }
    }
}