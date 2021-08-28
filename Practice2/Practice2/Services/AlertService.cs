﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice2.Services
{
    public class AlertService : IAlertService
    {
        public Task Alert(string title, string message, string cancel)
        {
            return App.Current.MainPage.DisplayAlert(title, message, cancel);
        }
    }
}
