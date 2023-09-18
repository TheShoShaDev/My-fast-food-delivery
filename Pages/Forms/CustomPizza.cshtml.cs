using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grill1.Models;

namespace WebApplication1.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        public ProductModel Pizza { get; set; }
        public void OnGet()
        {

        }
    }
}
