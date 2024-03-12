using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PokeNombre.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        [BindProperty]
        public int Mes { get; set; }
        public string Mensaje { get; set; }
        public void OnPost()
        {
            Nombre = Nombre.Substring(0, 1).ToUpper() + Nombre.Substring(1,2).ToLower();
            Mensaje = Nombre;
            switch (Mes)
            {
                case 1:
                    Mensaje += "ly";
                    break;
                case 2:
                    Mensaje += "ose";
                    break;
                case 3:
                    Mensaje += "ax";
                    break;
                case 4:
                    Mensaje += "ar";
                    break;
                case 5:
                    Mensaje += "vor";
                    break;
                case 6:
                    Mensaje += "lan";
                    break;
                case 7:
                    Mensaje += "der";
                    break;
                case 8:
                    Mensaje += "saur";
                    break;
                case 9:
                    Mensaje += "sey";
                    break;
                case 10:
                    Mensaje += "aza";
                    break;
                case 11:
                    Mensaje += "tar";
                    break;
                case 12:
                    Mensaje += "ven";
                    break;
            }
        }

    }
}
