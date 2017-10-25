using System;
using MvvmCross.Core.ViewModels;

namespace StartProject.Core.Domain.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        public string HelloMessage { get; set; }
        public string Username { get; set; }

        public void Init(string Username)
        {
            this.Username = Username;

            HelloMessage = $"Hey there {Username}!";
        }
    }
}
