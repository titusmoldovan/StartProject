using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using StartProject.Core.Domain.ViewModels;

namespace StartProject.iOS
{
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        public LoginViewController (IntPtr handle) : base (handle)
        {
        }
    }
}