using System.Collections.ObjectModel;

namespace FoodNet.Presentation.Models
{
	public enum OrderStatus
	{
		Processing,
		Preparing,
		OnTheWay,
		Delivered,
		Cancelled
	}

	public class OrderItem
	{
		public string Name { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public decimal Price { get; set; }
	}

	public class Order
	{
		public int Id { get; set; }
		public string Restaurant { get; set; } = string.Empty;
		public DateTime PlacedAt { get; set; }
		public OrderStatus Status { get; set; }
		public ObservableCollection<OrderItem> Items { get; set; } = new();

		public decimal Total => Items.Sum(i => i.Price * i.Quantity);
		public string TotalFormatted => Total.ToString("$0.00");
		public string Summary => string.Join(", ", Items.Take(2).Select(i => $"{i.Name} x{i.Quantity}")) + (Items.Count > 2 ? $" +{Items.Count - 2} more" : string.Empty);
		public string StatusText => Status switch
		{
			OrderStatus.Processing => "Processing",
			OrderStatus.Preparing => "Preparing",
			OrderStatus.OnTheWay => "On the way",
			OrderStatus.Delivered => "Delivered",
			OrderStatus.Cancelled => "Cancelled",
			_ => ""
		};
	}
}

