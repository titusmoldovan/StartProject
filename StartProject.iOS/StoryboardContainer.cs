using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using UIKit;

namespace StartProject.iOS
{
	public class StoryboardContainer : MvxIosViewsContainer
	{
		protected override IMvxIosView CreateViewOfType(Type viewType, MvxViewModelRequest request)
		{

            var a = UIStoryboard.FromName("Storyboard", null).InstantiateViewController(viewType.Name);
			return (IMvxIosView)a;
		}
	}
}
