﻿using System;
namespace SensorApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public Boolean checkInformation() {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }
    }
}
