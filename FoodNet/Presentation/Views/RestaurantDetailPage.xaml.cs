using FoodNet.Presentation.Models;
using System.Collections.ObjectModel;

namespace FoodNet.Presentation.Views;

[QueryProperty(nameof(RestaurantId), "restaurantId")]
public partial class RestaurantDetailPage : ContentPage
{
	private static IReadOnlyList<Restaurant>? _dataCache;

	public string? RestaurantId { get; set; }

	public RestaurantDetailPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		LoadRestaurant();
	}

	private T? GetByName<T>(string name) where T : Element => this.FindByName<T>(name);

	private void LoadRestaurant()
	{
		if (string.IsNullOrWhiteSpace(RestaurantId)) return;
		if (_dataCache is null)
		{
			// Recreate the same seed data as the list page
			_dataCache = new List<Restaurant>
			{
				new Restaurant
				{
					Id = 1, Name = "Italiano Bistro", Cuisine = "Italian", Rating = 4.7, DeliveryTime = "25-35 min", ImageEmoji = "🍝",
					Offers = new ObservableCollection<string>{"20% OFF","Free Tiramisu"}, VoucherText = "SAVE10 - Save $10 on $30+",
					MenuItems = new ObservableCollection<MenuItemModel>
					{
						new MenuItemModel{ Id=1, Name="Margherita Pizza", Emoji="🍕", Price=12.99m },
						new MenuItemModel{ Id=2, Name="Pasta Carbonara", Emoji="🍝", Price=10.49m },
						new MenuItemModel{ Id=3, Name="Garlic Bread", Emoji="🍞", Price=4.99m },
					}
				},
				new Restaurant
				{
					Id = 2, Name = "Sushi Master", Cuisine = "Japanese", Rating = 4.9, DeliveryTime = "30-45 min", ImageEmoji = "🍣",
					Offers = new ObservableCollection<string>{"Buy 1 Get 1","Free Miso Soup"}, VoucherText = "FRESH5 - 5% off first order",
					MenuItems = new ObservableCollection<MenuItemModel>
					{
						new MenuItemModel{ Id=4, Name="Salmon Roll", Emoji="🍣", Price=8.99m },
						new MenuItemModel{ Id=5, Name="Tuna Nigiri", Emoji="🐟", Price=11.49m },
						new MenuItemModel{ Id=6, Name="Edamame", Emoji="🫛", Price=3.99m },
					}
				},
				new Restaurant
				{
					Id = 3, Name = "Burger House", Cuisine = "American", Rating = 4.6, DeliveryTime = "20-30 min", ImageEmoji = "🍔",
					Offers = new ObservableCollection<string>{"Free Delivery","Combo Saver"}, VoucherText = "MEAL15 - 15% off meals",
					MenuItems = new ObservableCollection<MenuItemModel>
					{
						new MenuItemModel{ Id=7, Name="Classic Burger", Emoji="🍔", Price=9.99m },
						new MenuItemModel{ Id=8, Name="Fries", Emoji="🍟", Price=3.49m },
						new MenuItemModel{ Id=9, Name="Chocolate Shake", Emoji="🥤", Price=4.49m },
					}
				}
			};
		}

		if (int.TryParse(RestaurantId, out var id))
		{
			var restaurant = _dataCache.FirstOrDefault(r => r.Id == id);
			if (restaurant is null) return;

			var restaurantEmoji = GetByName<Label>("RestaurantEmoji");
			var restaurantName = GetByName<Label>("RestaurantName");
			var restaurantMeta = GetByName<Label>("RestaurantMeta");
			var offersList = GetByName<CollectionView>("OffersList");
			var voucherText = GetByName<Label>("VoucherText");
			var menuList = GetByName<CollectionView>("MenuList");

			if (restaurantEmoji != null) restaurantEmoji.Text = restaurant.ImageEmoji;
			if (restaurantName != null) restaurantName.Text = restaurant.Name;
			if (restaurantMeta != null) restaurantMeta.Text = $"⭐ {restaurant.Rating} • {restaurant.DeliveryTime}";
			if (offersList != null) offersList.ItemsSource = restaurant.Offers;
			if (voucherText != null) voucherText.Text = restaurant.VoucherText;
			if (menuList != null) menuList.ItemsSource = restaurant.MenuItems;
		}
	}

	private async void OnAddToCartClicked(object sender, EventArgs e)
	{
		await DisplayAlert("Added", "Item added to cart.", "OK");
	}
}

