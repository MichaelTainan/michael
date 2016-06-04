// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace michael.iOS
{
	[Register ("MenuViewController")]
	partial class MenuViewController
	{
		[Outlet]
		UIKit.UIButton btnFirst { get; set; }

		[Outlet]
		UIKit.UIButton btnReturn { get; set; }

		[Outlet]
		UIKit.UIButton btnSecond { get; set; }

		[Outlet]
		UIKit.UIView viewToSimulateButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnFirst != null) {
				btnFirst.Dispose ();
				btnFirst = null;
			}

			if (btnSecond != null) {
				btnSecond.Dispose ();
				btnSecond = null;
			}

			if (btnReturn != null) {
				btnReturn.Dispose ();
				btnReturn = null;
			}

			if (viewToSimulateButton != null) {
				viewToSimulateButton.Dispose ();
				viewToSimulateButton = null;
			}
		}
	}
}
