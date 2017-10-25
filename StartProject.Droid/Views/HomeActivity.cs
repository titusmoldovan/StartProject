using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using StartProject.Core.Domain.ViewModels;

namespace StartProject.Droid.Views
{
    [Activity(Label = "HomeActivity")]
    public class HomeActivity : MvxAppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.home_layout);
        }
    }
}
