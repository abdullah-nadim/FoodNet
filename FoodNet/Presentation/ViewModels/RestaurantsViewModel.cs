using System.Collections.ObjectModel;
using System.ComponentModel;
using FoodNet.Presentation.Models;

namespace FoodNet.Presentation.ViewModels
{
	public class RestaurantsViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public ObservableCollection<Restaurant> Restaurants { get; } = new();

		public RestaurantsViewModel()
		{
			Seed();
		}

		private void Seed()
		{
			Restaurants.Clear();
			Restaurants.Add(new Restaurant
			{
				Id = 1,
				Name = "Italiano Bistro",
				Cuisine = "Italian",
				Rating = 4.7,
				DeliveryTime = "25-35 min",
				ImageEmoji = "🍝",
				Offers = new ObservableCollection<string> { "20% OFF", "Free Tiramisu" },
				VoucherText = "SAVE10 - Save $10 on $30+",
				MenuItems = new ObservableCollection<MenuItemModel>
				{
					new MenuItemModel{ Id=1, Name="Margherita Pizza", Emoji="🍕", Price=12.99m },
					new MenuItemModel{ Id=2, Name="Pasta Carbonara", Emoji="🍝", Price=10.49m },
					new MenuItemModel{ Id=3, Name="Garlic Bread", Emoji="🍞", Price=4.99m },
					new MenuItemModel{ Id=10, Name="Lasagna", Emoji="🧀", Price=11.99m },
					new MenuItemModel{ Id=11, Name="Bruschetta", Emoji="🍅", Price=5.49m },
					new MenuItemModel{ Id=12, Name="Tiramisu", Emoji="🍰", Price=6.49m },
				}
			});

			Restaurants.Add(new Restaurant
			{
				Id = 2,
				Name = "Sushi Master",
				Cuisine = "Japanese",
				Rating = 4.9,
				DeliveryTime = "30-45 min",
				ImageEmoji = "🍣",
				Offers = new ObservableCollection<string> { "Buy 1 Get 1", "Free Miso Soup" },
				VoucherText = "FRESH5 - 5% off first order",
				MenuItems = new ObservableCollection<MenuItemModel>
				{
					new MenuItemModel{ Id=4, Name="Salmon Roll", Emoji="🍣", Price=8.99m },
					new MenuItemModel{ Id=5, Name="Tuna Nigiri", Emoji="🐟", Price=11.49m },
					new MenuItemModel{ Id=6, Name="Edamame", Emoji="🫛", Price=3.99m },
					new MenuItemModel{ Id=13, Name="California Roll", Emoji="🥑", Price=7.99m },
					new MenuItemModel{ Id=14, Name="Shrimp Tempura", Emoji="🍤", Price=9.49m },
					new MenuItemModel{ Id=15, Name="Miso Soup", Emoji="🍲", Price=2.99m },
				}
			});

			Restaurants.Add(new Restaurant
			{
				Id = 3,
				Name = "Burger House",
				Cuisine = "American",
				Rating = 4.6,
				DeliveryTime = "20-30 min",
				ImageEmoji = "🍔",
				Offers = new ObservableCollection<string> { "Free Delivery", "Combo Saver" },
				VoucherText = "MEAL15 - 15% off meals",
				MenuItems = new ObservableCollection<MenuItemModel>
				{
					new MenuItemModel{ Id=7, Name="Classic Burger", Emoji="🍔", Price=9.99m },
					new MenuItemModel{ Id=8, Name="Fries", Emoji="🍟", Price=3.49m },
					new MenuItemModel{ Id=9, Name="Chocolate Shake", Emoji="🥤", Price=4.49m },
					new MenuItemModel{ Id=16, Name="Cheese Burger", Emoji="🧀", Price=10.99m },
					new MenuItemModel{ Id=17, Name="Chicken Nuggets", Emoji="🍗", Price=5.99m },
					new MenuItemModel{ Id=18, Name="Onion Rings", Emoji="🧅", Price=3.99m },
				}
			});
		}
	}
}

