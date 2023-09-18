using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grill1.Models;
using static Grill1.Helpers.Helpers;
using Dapper.Contrib.Extensions;
using Dapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

namespace Grill1.Pages.Forms
{
    public class ProductPageModel : PageModel
    {
		public ProductModel Product = new ProductModel();
		
        [BindProperty(SupportsGet = true)]
		public int Id { get; set; }

		public void OnGet()
        {
			int _Id = Id;
			_Id++;
			string sqlQuery = "SELECT * FROM Products Where Id = '" + _Id + "'";
			using (var db = DbHelper.GetConnection())
			{
									
				var gotProduct = db.QuerySingleOrDefault(sqlQuery);

				if (gotProduct != null)
				{
					Product.Id = gotProduct.Id;
					Product.ImageTitle = gotProduct.ImageTitle;
					Product.ProductName = gotProduct.ProductName;
					Product.ProductDescription = gotProduct.ProductDescription;
					Product.ProductPrize = gotProduct.ProductPrize;
				}
				else
				{

				}
			
			}

        }

        public void OnPost() 
        {

		}
	}
}
