// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace StartProject.iOS
{
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel GreetingMessageLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (GreetingMessageLabel != null) {
                GreetingMessageLabel.Dispose ();
                GreetingMessageLabel = null;
            }
        }


    }
}