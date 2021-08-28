using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Practice2.Models
{
    public class LoginModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _username;
        public string Username
        {
            get
            { 
                return _username; 
            }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _password;
        public string Password
        {
            get
            { 
                return _password; 
            }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
