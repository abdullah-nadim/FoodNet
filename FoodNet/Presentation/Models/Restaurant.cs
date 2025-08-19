using System.Collections.ObjectModel;

namespace FoodNet.Presentation.Models
{
	public class MenuItemModel
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Emoji { get; set; } = string.Empty;
		public decimal Price { get; set; }
	}

	public class Restaurant
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string Cuisine { get; set; } = string.Empty;
		public double Rating { get; set; }
		public string DeliveryTime { get; set; } = string.Empty;
		public string ImageEmoji { get; set; } = string.Empty;
		public ObservableCollection<string> Offers { get; set; } = new();
		public string VoucherText { get; set; } = string.Empty;
		public ObservableCollection<MenuItemModel> MenuItems { get; set; } = new();
	}
}

