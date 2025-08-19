namespace FoodNet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOffersTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("MainPage");
        }

        private async void OnRestaurantsTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("RestaurantsPage");
        }

        private async void OnOrdersTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("OrdersPage");
        }

        private async void OnProfileTapped(object sender, TappedEventArgs e)
        {
            await Shell.Current.GoToAsync("UserProfilePage");
        }
    }
}
