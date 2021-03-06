// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using Debug = System.Diagnostics.Debug ;

namespace michael.iOS
{
	public partial class MenuViewController : UIViewController
	{
		private bool SimTouchClick { get; set; }

		public MenuViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			btnReturn.TouchUpInside += (object sender, EventArgs e) => {
				
				InvokeOnMainThread (
					() => {
						this.PerformSegue ("moveToInitViewSegue",this);
						
					}
				);
			};

			btnFirst.TouchUpInside += (object sender, EventArgs e) => {

				InvokeOnMainThread (
					()=>{
						this.PerformSegue("moveToFirstViewSegue", this);
					}
				);
			};

			btnSecond.TouchUpInside += (object sender, EventArgs e) => {

				InvokeOnMainThread (
					()=>{
						this.PerformSegue("moveToSecondViewSegue", this);
					}
				);
			};

			var tap = new UITapGestureRecognizer (() => {
				Debug.WriteLine(@"tap");

				this.viewToSimulateButton.BackgroundColor = UIColor.LightGray ;
				SimTouchClick = true;
			});

			this.viewToSimulateButton.AddGestureRecognizer (tap);
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);


			var touch = touches.AnyObject as UITouch;

			var pointOfView = touch.LocationInView (this.viewToSimulateButton);

			Debug.WriteLine ( $"X:{pointOfView.X}, Y:{pointOfView.Y}"   ); 

			if (pointOfView.X > 0 && pointOfView.X < viewToSimulateButton.Bounds.Width  && pointOfView.Y > 0 && pointOfView.Y < viewToSimulateButton.Bounds.Height ) {
				this.viewToSimulateButton.BackgroundColor = UIColor.LightGray ;
				SimTouchClick = true;

				//Rectangle rect = new Rectangle (0, 0, 300, 100);
				//viewToSimulateButton.Frame = rect; 
			}


		}

		public override void TouchesEnded (NSSet touches, UIEvent evt)
		{
			base.TouchesEnded (touches, evt);


			var touch = touches.AnyObject as UITouch;

			if (SimTouchClick) {
				SimTouchClick = false;
				this.viewToSimulateButton.BackgroundColor = UIColor.DarkGray ;
			}

		}

	}
}
