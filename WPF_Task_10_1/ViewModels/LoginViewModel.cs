using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WPF_Task_10_1.Models;

namespace WPF_Task_10_1.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _statusMessage;
        private bool _isSuccess;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public string StatusMessage
        {
            get => _statusMessage;
            set
            {
                _statusMessage = value;
                OnPropertyChanged();
            }
        }

        public bool IsSuccess
        {
            get => _isSuccess;
            set
            {
                _isSuccess = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(
                execute: Login,
                canExecute: CanLogin
                
            );
            
        }

        private bool CanLogin(object parameter)
        {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        }

        private void Login(object parameter)
        {
            bool isAuthenticated = AuthModel.Authenticate(Username, Password);

            if (isAuthenticated)
            {
                IsSuccess = true;
                StatusMessage = "Вход выполнен успешно!";
            }
            else
            {
                IsSuccess = false;
                StatusMessage = "Ошибка: неверный логин или пароль.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}