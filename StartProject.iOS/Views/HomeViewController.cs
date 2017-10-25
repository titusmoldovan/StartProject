using Foundation;
using System;
using UIKit;
using MvvmCross.iOS.Views;
using StartProject.Core.Domain.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace StartProject.iOS
{
    public partial class HomeViewController : MvxViewController<HomeViewModel>
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
            View.BackgroundColor = UIColor.Green;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<HomeViewController, HomeViewModel>();

            set.Bind(GreetingMessageLabel)
               .For(label => label.Text)
               .To(vm => vm.HelloMessage);

            set.Apply();
        }
    }
}