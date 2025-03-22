using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TabElementAndreev.Models;

namespace TabElementAndreev.ViewModels
{
    public partial class RegistrationViewModel : ObservableObject
    {
        private readonly List<User> _users;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        public RegistrationViewModel()
        {
            _users = LoginViewModel.GetUsers();
        }

        [RelayCommand]
        public async Task RegistrationAsync()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await AppShell.Current.DisplayAlert("Ошибка", "Введите логин и пароль", "OK");
                return;
            }

            if (_users.Any(u => u.Username == Username))
            {
                await AppShell.Current.DisplayAlert("Ошибка", "Пользователь уже существует", "OK");
                return;
            }

            _users.Add(new User(Username, Password));
            await AppShell.Current.DisplayAlert("Успех", "Регистрация успешно завершена", "OK");
            await AppShell.Current.GoToAsync("///LoginView");
        }

        [RelayCommand]
        public async Task GoToLoginAsync()
        {
            await AppShell.Current.GoToAsync("///LoginView");
        }
    }
}