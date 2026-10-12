using laber1.PK;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace laber1.Pages
{
    public class IndexModel : PageModel
    {
        public GamingPC Computer { get; set; }
        public void OnGet()
        {
            Computer = new GamingPC("Lenovo", "Intel Core i7",64,1024, "Windows 10", "RTX 4090",1000,true);
        }
    }
}
