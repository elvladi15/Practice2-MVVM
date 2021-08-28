using Practice2.Models;
using Practice2.Services;
using Practice2.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Practice2.ViewModels
{
    public class RegisterViewModel
    {
        private IAlertService _alertService;
        public RegisterModel RegisterModel { get; set; } = new RegisterModel();
        public ICommand GoToLoginPageCommand { get; }
        public ICommand RegisterButtonCommand { get; }
        public RegisterViewModel(IAlertService alertService)
        {
            _alertService = alertService;
            GoToLoginPageCommand = new Command(GoToLoginPage);
            RegisterButtonCommand = new Command(RegisterButton);
        }
        async private void GoToLoginPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }
        private async void RegisterButton()
        {
            if (string.IsNullOrWhiteSpace(RegisterModel.Username) ||
                string.IsNullOrWhiteSpace(RegisterModel.Email) ||
                string.IsNullOrWhiteSpace(RegisterModel.Password) ||
                string.IsNullOrWhiteSpace(RegisterModel.PasswordConfirm))
            {
                await _alertService.Alert("Error", "Please fill all the fields", "OK");
            }
            else
            {
                await _alertService.Alert("Register successful", "Your account has been created successfully", "OK");
            }
        }
    }
}
