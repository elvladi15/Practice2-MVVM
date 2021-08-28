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
    public class LoginViewModel
    {
        private IAlertService _alertService;

        public LoginModel LoginModel { get; set; } = new LoginModel();
        public ICommand GoToRegisterPageCommand { get; }
        public ICommand LoginButtonCommand { get; }
        public LoginViewModel(IAlertService alertService)
        {
            _alertService = alertService;
            GoToRegisterPageCommand = new Command(GoToRegisterPage);
            LoginButtonCommand = new Command(LoginButton);
        }

        async private void GoToRegisterPage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
        async private void LoginButton()
        {
            if (string.IsNullOrWhiteSpace(LoginModel.Username) || string.IsNullOrWhiteSpace(LoginModel.Password))
            {
                await _alertService.Alert("Error", "Please fill all the fields", "OK");
            }
            else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }    
        }
    }
}
