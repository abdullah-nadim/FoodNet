using FoodNet.Presentation.Models;

namespace FoodNet;

public partial class RestaurantsPage : ContentPage
{
	public RestaurantsPage()
	{
		InitializeComponent();
	}

	private async void OnRestaurantTapped(object sender, TappedEventArgs e)
	{
		if (e.Parameter is Restaurant restaurant)
		{
			var route = $"RestaurantDetailPage?restaurantId={restaurant.Id}";
			await Shell.Current.GoToAsync(route);
		}
	}
} 