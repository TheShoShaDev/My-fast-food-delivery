using Dapper;
using Grill1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Grill1.Helpers.Helpers;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

		public List<Pizza> GetPizzaList()
		{
			using (var db = DbHelper.GetConnection())
            {
                List<Pizza> PizzasList = db.Query<Pizza>("SELECT * FROM Products Where ProductType = 'Pizza' ORDER BY ProductName DESC").ToList();

                return PizzasList;
			}
		}
	}
}