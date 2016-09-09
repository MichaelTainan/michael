// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace michael.iOS
{
	[Register ("InitViewController")]
	partial class InitViewController
	{
		[Outlet]
		UIKit.UIButton btnSend { get; set; }

		[Outlet]
		UIKit.UIButton btnTest { get; set; }

		[Outlet]
		UIKit.UILabel lbMessage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnTest != null) {
				btnTest.Dispose ();
				btnTest = null;
			}

			if (btnSend != null) {
				btnSend.Dispose ();
				btnSend = null;
			}

			if (lbMessage != null) {
				lbMessage.Dispose ();
				lbMessage = null;
			}
		}
	}
}
