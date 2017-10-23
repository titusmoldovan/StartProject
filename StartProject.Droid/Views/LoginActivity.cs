using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using StartProject.Core.Domain.ViewModels;

namespace StartProject.Droid.Views
{
    [Activity(Label = "LoginActivity",
			 LaunchMode = LaunchMode.SingleTask,
			 ScreenOrientation = ScreenOrientation.Portrait,
			 WindowSoftInputMode = Android.Views.SoftInput.AdjustResize)]
	public class LoginActivity : MvxAppCompatActivity<LoginViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.login_activity_layout);
        }
    }
}