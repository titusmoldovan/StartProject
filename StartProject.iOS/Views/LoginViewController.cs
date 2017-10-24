using System;
using UIKit;
using MvvmCross.iOS.Views;
using StartProject.Core.Domain.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace StartProject.iOS
{
    public partial class LoginViewController : MvxViewController<LoginViewModel>
    {
        public LoginViewController (IntPtr handle) : base (handle)
        {
            View.BackgroundColor = UIColor.Cyan;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<LoginViewController, LoginViewModel>();

            set.Bind(UsernameTextField)
               .For("Placeholder")
               .To(vm => vm.UsernamePlaceholder);
          
            set.Bind(LoginButton)
               .For("Title")
               .To(vm => vm.LoginButtonText);

            set.Bind(LoginButton)
               .To(vm => vm.LoginCommand);

            set.Apply();
        }
    }
}