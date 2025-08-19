namespace FoodNet;

public partial class OrdersPage : ContentPage
{
	public OrdersPage()
	{
		InitializeComponent();
	}

	private async void OnStartOrderingClicked(object sender, EventArgs e)
	{
		await Shell.Current.GoToAsync("//RestaurantsPage");
	}
} 