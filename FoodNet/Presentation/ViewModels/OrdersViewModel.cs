using System.Collections.ObjectModel;
using System.ComponentModel;
using FoodNet.Presentation.Models;

namespace FoodNet.Presentation.ViewModels
{
	public class OrdersViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		public ObservableCollection<Order> Orders { get; } = new();

		public OrdersViewModel()
		{
			Seed();
		}

		private void Seed()
		{
			Orders.Clear();
			Orders.Add(new Order
			{
				Id = 101,
				Restaurant = "Italiano Bistro",
				PlacedAt = DateTime.Now.AddMinutes(-45),
				Status = OrderStatus.Preparing,
				Items = new ObservableCollection<OrderItem>
				{
					new OrderItem{ Name="Margherita Pizza", Quantity=1, Price=12.99m },
					new OrderItem{ Name="Garlic Bread", Quantity=1, Price=4.99m },
				}
			});

			Orders.Add(new Order
			{
				Id = 102,
				Restaurant = "Sushi Master",
				PlacedAt = DateTime.Now.AddHours(-2),
				Status = OrderStatus.OnTheWay,
				Items = new ObservableCollection<OrderItem>
				{
					new OrderItem{ Name="Salmon Roll", Quantity=2, Price=8.99m },
					new OrderItem{ Name="Miso Soup", Quantity=1, Price=2.99m },
				}
			});

			Orders.Add(new Order
			{
				Id = 103,
				Restaurant = "Burger House",
				PlacedAt = DateTime.Now.AddDays(-1),
				Status = OrderStatus.Delivered,
				Items = new ObservableCollection<OrderItem>
				{
					new OrderItem{ Name="Classic Burger", Quantity=1, Price=9.99m },
					new OrderItem{ Name="Fries", Quantity=1, Price=3.49m },
					new OrderItem{ Name="Shake", Quantity=1, Price=4.49m },
				}
			});
		}
	}
}

