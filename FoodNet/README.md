# FoodNet - Food Delivery App

## Overview
FoodNet is a modern food delivery app built with .NET MAUI, inspired by FoodPanda. This project includes a comprehensive food delivery interface with restaurant listings, food categories, special offers, and a user profile system with a clean, modern design and light theme.

## Features

### Main Food Delivery Interface
- **Top Banner**: Search bar with location services and app branding
- **Food Categories**: Horizontal scrollable categories (Pizza, Burgers, Sushi, Desserts, Coffee)
- **Popular Food Items**: Featured dishes with ratings, delivery time, and pricing
- **Special Offers**: Promotional cards with discounts and deals
- **Bottom Navigation**: Four-tab navigation (Offers, Restaurants, Orders, Profile)

### Food Categories
- Pizza 🍕
- Burgers 🍔
- Sushi 🍣
- Desserts 🍰
- Coffee ☕

### Popular Food Items
- Margherita Pizza - $12.99
- Classic Burger - $9.99
- Salmon Sushi Roll - $15.99

### Special Offers
- 50% OFF on first order
- Free delivery on orders over $25
- Buy 1 Get 1 on selected items

### User Profile Page
- **Modern Design**: Clean, card-based layout with rounded corners and subtle shadows
- **Light Theme**: White background with light gray accents and modern color palette
- **Profile Image**: Circular profile image with camera icon overlay for easy photo changes
- **Editable Information**: Toggle between view and edit modes
- **Form Validation**: Basic validation for required fields (first name, last name, email)

### User Information Fields
- First Name
- Last Name
- Email Address
- Phone Number
- Date of Birth
- Location
- Bio/About Me

### Navigation
- Tab-based navigation with four main sections
- Easy navigation between pages
- Modern tab bar design

## Design System

### Color Palette
- **Primary**: #6366F1 (Indigo)
- **Secondary**: #F3F4F6 (Light Gray)
- **Background**: #FFFFFF (White)
- **Surface**: #F9FAFB (Very Light Gray)
- **Text Primary**: #111827 (Dark Gray)
- **Text Secondary**: #6B7280 (Medium Gray)
- **Border**: #E5E7EB (Light Gray)

### Typography
- Clean, modern font hierarchy
- Proper contrast ratios for accessibility
- Consistent spacing and padding

## File Structure

```
FoodNet/
├── Presentation/
│   ├── Models/
│   │   └── UserProfile.cs
│   ├── ViewModels/
│   │   └── UserProfileViewModel.cs
│   └── Views/
│       ├── UserProfilePage.xaml
│       └── UserProfilePage.xaml.cs
├── Resources/
│   ├── Styles/
│   │   └── Colors.xaml (Updated with light theme)
│   └── Images/
│       ├── dotnet_bot.png
│       ├── offers.png (placeholder)
│       ├── restaurants.png (placeholder)
│       ├── orders.png (placeholder)
│       └── profile.png (placeholder)
├── AppShell.xaml (Updated with four-tab navigation)
├── MainPage.xaml (FoodPanda-style main interface)
├── RestaurantsPage.xaml (Restaurants listing page)
└── OrdersPage.xaml (Orders tracking page)
```

## Usage

### Main Interface
1. Launch the app to see the main food delivery interface
2. Use the search bar to find restaurants and dishes
3. Browse food categories by scrolling horizontally
4. View popular food items with ratings and delivery times
5. Check out special offers and promotions

### Navigation
1. **Offers Tab**: View current promotions and deals
2. **Restaurants Tab**: Browse available restaurants
3. **Orders Tab**: Track your food delivery orders
4. **Profile Tab**: Manage your user profile

### Viewing Profile
1. Navigate to the "Profile" tab
2. View your profile information in read-only mode

### Editing Profile
1. Click the "Edit" button in the top-right corner
2. Modify any of the editable fields
3. Click "Save" to save changes or "Cancel" to discard changes

### Changing Profile Photo
1. Tap on the profile image (camera icon overlay)
2. In a real implementation, this would open a photo picker

## Technical Implementation

### MVVM Pattern
- **Model**: `UserProfile` - Data structure with property change notifications
- **ViewModel**: `UserProfileViewModel` - Business logic and state management
- **View**: `UserProfilePage` - UI presentation and user interaction

### Data Binding
- Two-way data binding for form fields
- Command binding for buttons
- Property change notifications for real-time UI updates

### Navigation
- Shell-based navigation with tab bar
- Route registration for deep linking
- Async navigation with proper error handling

## Future Enhancements

### Planned Features
- Photo picker integration for profile images
- Data persistence (local storage or cloud)
- Advanced form validation
- Profile sharing capabilities
- Social media integration
- Recipe favorites and collections

### UI Improvements
- Custom profile image picker
- Animated transitions
- Dark theme support
- Accessibility improvements
- Localization support

## Getting Started

1. Clone the repository
2. Open the solution in Visual Studio 2022
3. Restore NuGet packages
4. Build and run the project
5. Navigate to the Profile tab to see the user profile feature

## Requirements

- .NET 9.0
- Visual Studio 2022 17.8 or later
- .NET MAUI workload
- Windows 10/11, macOS, or Android/iOS device for testing

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Test thoroughly
5. Submit a pull request

## License

This project is licensed under the MIT License. 