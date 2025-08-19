using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FoodNet.Presentation.Models;
using System.Collections.Generic;
using System;

namespace FoodNet.Presentation.ViewModels
{
    public class UserProfileViewModel : INotifyPropertyChanged
    {
        private UserProfile _userProfile;
        private bool _isEditing;
        private UserProfile _originalProfile;

        public UserProfileViewModel()
        {
            UserProfile = new UserProfile
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Phone = "+1 (555) 123-4567",
                Bio = "Food enthusiast and culinary explorer. Love trying new recipes and discovering local cuisines.",
                DateOfBirth = new DateTime(1990, 5, 15),
                Location = "New York, NY",
                ProfileImagePath = "dotnet_bot.png"
            };

            EditCommand = new Command(OnEdit);
            SaveCommand = new Command(OnSave, CanSave);
            CancelCommand = new Command(OnCancel, CanCancel);
            ChangePhotoCommand = new Command(OnChangePhoto);
        }

        public UserProfile UserProfile
        {
            get => _userProfile;
            set => SetProperty(ref _userProfile, value);
        }

        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                if (SetProperty(ref _isEditing, value))
                {
                    OnPropertyChanged(nameof(IsViewing));
                    ((Command)SaveCommand).ChangeCanExecute();
                    ((Command)CancelCommand).ChangeCanExecute();
                }
            }
        }

        public bool IsViewing => !IsEditing;

        public ICommand EditCommand { get; }
        public ICommand SaveCommand { get; }
        public ICommand CancelCommand { get; }
        public ICommand ChangePhotoCommand { get; }

        private void OnEdit()
        {
            _originalProfile = new UserProfile
            {
                FirstName = UserProfile.FirstName,
                LastName = UserProfile.LastName,
                Email = UserProfile.Email,
                Phone = UserProfile.Phone,
                Bio = UserProfile.Bio,
                DateOfBirth = UserProfile.DateOfBirth,
                Location = UserProfile.Location,
                ProfileImagePath = UserProfile.ProfileImagePath
            };
            IsEditing = true;
        }

        private void OnSave()
        {
            // Here you would typically save to a database or service
            IsEditing = false;
            _originalProfile = null;
        }

        private bool CanSave()
        {
            return IsEditing && !string.IsNullOrWhiteSpace(UserProfile.FirstName) && 
                   !string.IsNullOrWhiteSpace(UserProfile.LastName) && 
                   !string.IsNullOrWhiteSpace(UserProfile.Email);
        }

        private void OnCancel()
        {
            if (_originalProfile != null)
            {
                UserProfile.FirstName = _originalProfile.FirstName;
                UserProfile.LastName = _originalProfile.LastName;
                UserProfile.Email = _originalProfile.Email;
                UserProfile.Phone = _originalProfile.Phone;
                UserProfile.Bio = _originalProfile.Bio;
                UserProfile.DateOfBirth = _originalProfile.DateOfBirth;
                UserProfile.Location = _originalProfile.Location;
                UserProfile.ProfileImagePath = _originalProfile.ProfileImagePath;
            }
            IsEditing = false;
            _originalProfile = null;
        }

        private bool CanCancel()
        {
            return IsEditing;
        }

        private void OnChangePhoto()
        {
            // Here you would implement photo selection logic
            // For now, we'll just show a placeholder
            UserProfile.ProfileImagePath = "dotnet_bot.png";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
} 