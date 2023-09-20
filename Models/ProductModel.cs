namespace Grill1.Models
{
	public class ProductModel : ProductInterface
	{
		public string ImageTitle { get; set; }
		public string ProductName { get; set; }
		public string ProductDescription { get; set; }
		public float ProductPrize { get; set; }
		public string ExtraDescripton { get; set; }
		public int Id { get; set; }

	}

	public class Pizza : ProductModel
	{
		public bool ExtraCheese { get; set; }
		public bool ExtraSouse { get; set; }
		public bool ExtraMushrooms { get; set; }

	}


}
