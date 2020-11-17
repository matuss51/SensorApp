using System;
using System.Collections.Generic;
using SensorApp.Models;
using Xamarin.Forms;

namespace SensorApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_username.TextColor = Constants.MainTextColor;
            Lbl_password.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;

            LoginIcon.HeightRequest = Constants.LoginIconHeight;

            Entry_username.Completed += (s, e) => Entry_password.Focus();
            Entry_password.Completed += (s, e) => SignInProcedure(s, e);
        }

        void SignInProcedure(object sender, EventArgs e) {
            User user = new User(Entry_username.Text, Entry_password.Text);
            if (user.checkInformation()) {
                DisplayAlert("Login", "Login success", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Login not correct, username or password is empty", "NOk");
            }
        }
    }
}
