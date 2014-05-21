using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Behavior.Models;

namespace Behavior.ViewModels
{
    public class UserViewModel
    {
        public UserModel user { get; set; }

        public UserViewModel()
        {
            user = new UserModel();
            user.UserName = "John";
        }

        public LoginCommand Login
        {
            get { return new LoginCommand(); }
        }
        public ResetCommand Reset
        {
            get { return new ResetCommand(); }
        }
    }

    public class LoginCommand : ICommand
    {

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            UserViewModel uservm = parameter as UserViewModel;
            if (uservm.user.UserName.Equals("admin") && uservm.user.Password.Equals("123"))
            {
                MessageBox.Show("Login Success", "System Info", MessageBoxButton.OK);
            }
            else
            {
                MessageBox.Show("Login failed", "System Info", MessageBoxButton.OK);
            }

        }
    }

    public class ResetCommand : ICommand
    {

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            UserViewModel uservm = parameter as UserViewModel;
            uservm.user.UserName = "";
            uservm.user.Password = "";
        }
    }
}
