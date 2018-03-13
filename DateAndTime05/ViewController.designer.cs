// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace DateAndTime05
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnDateTime { get; set; }

		[Outlet]
		UIKit.UIButton btnNSDate { get; set; }

		[Outlet]
		UIKit.UILabel lblDate { get; set; }

		[Outlet]
		UIKit.UILabel lblTime { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (lblDate != null) {
				lblDate.Dispose ();
				lblDate = null;
			}

			if (lblTime != null) {
				lblTime.Dispose ();
				lblTime = null;
			}

			if (btnNSDate != null) {
				btnNSDate.Dispose ();
				btnNSDate = null;
			}

			if (btnDateTime != null) {
				btnDateTime.Dispose ();
				btnDateTime = null;
			}
		}
	}
}
