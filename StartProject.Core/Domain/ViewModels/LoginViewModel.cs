using System;
using MvvmCross.Core.ViewModels;

namespace StartProject.Core.Domain.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        string _username;
		public string Username
		{
			get => _username;
			set => SetProperty(ref _username, value);
		}

        public string UsernamePlaceholder
        {
            get => "Username";
        }

        public string LoginButtonText
        {
            get => "LOGIN";
        }

        public IMvxCommand LoginCommand { get; private set; }

        public LoginViewModel()
        {
            LoginCommand = new MvxCommand(OnLoginClicked);
        }

        void OnLoginClicked()
        {
           
        }
    }
}