using Grill1.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grill1.Pages.Forms
{
	//[Authorize]
	public class AdminPageModel : PageModel
    {
        ProductModel Product = new ProductModel();

        public void OnGet()
        {
            
        }
    }
}
