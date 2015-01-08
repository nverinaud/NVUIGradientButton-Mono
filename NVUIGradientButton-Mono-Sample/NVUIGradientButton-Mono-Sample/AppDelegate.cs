//
//  Author:
//       Nicolas VERINAUD <nicolas@chloro.eu>
//
//  Copyright (c) 2014 Chlorophyll Vision. All Rights Reserved.
//
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using NV;
using CoreGraphics;

namespace NVUIGradientButtonMonoSample
{
	[Register("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			window = new UIWindow(UIScreen.MainScreen.Bounds);
			window.BackgroundColor = UIColor.White;

			var button = new NVUIGradientButton(new CGRect(20, 20, 280, 44), NVUIGradientButtonStyle.BlackTranslucent);
			button.Text = "Hello Button";
			window.AddSubview(button);

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

