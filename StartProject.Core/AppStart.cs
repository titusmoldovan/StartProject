using MvvmCross.Core.ViewModels;
using StartProject.Core.Domain.ViewModels;

namespace StartProject.Core
{
	public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<LoginViewModel>();
        }
    }
}
