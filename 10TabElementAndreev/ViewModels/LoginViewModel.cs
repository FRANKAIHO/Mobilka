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
    public partial class LoginViewModel: ObservableObject
    {
        private static List<User> _users = new()
        {
            new User("admin", "password")
        };

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [RelayCommand]
        public async Task LoginAsync()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                await AppShell.Current.DisplayAlert("Ошибка", "Введите логин и пароль", "OK");
                return;
            }

            var user = _users.FirstOrDefault(u => u.Username == Username && u.Password == Password);

            if (user != null)
            {
                await AppShell.Current.GoToAsync("///FirstView");
            }
            else
            {
                await AppShell.Current.DisplayAlert("Ошибка", "Неверный логин или пароль", "OK");
            }
        }

        [RelayCommand]
        public async Task GoToRegistrationAsync()
        {
            await AppShell.Current.GoToAsync("///RegistrationView");
        }

        public static List<User> GetUsers()
        {
            return _users;
        }
    }
}
