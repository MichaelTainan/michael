// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace michael.iOS
{
	public partial class SecondViewController : UIViewController
	{
		public SecondViewController (IntPtr handle) : base (handle)
		{
			
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			btnBack.TouchUpInside += (object sender, EventArgs e) => {
				DismissViewController(true, null);
			};

		}
	}
}
