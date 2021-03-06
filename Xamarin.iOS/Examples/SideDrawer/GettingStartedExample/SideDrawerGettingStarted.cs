﻿using System;
using UIKit;
using Foundation;
using CoreGraphics;
using ObjCRuntime;
using TelerikUI;

namespace Examples
{
	[Register("SideDrawerGettingStarted")]
	public class SideDrawerGettingStarted : XamarinExampleViewController
	{
		private TKSideDrawerSection primarySection;
		private TKSideDrawerSection labelsSection;
		SideDrawerDelegate sideDrawerDelegate;

		public UINavigationItem NavItem {
			get;
			set;
		}

		public TKSideDrawerView SideDrawerView {
			get;
			set;
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		
			this.SideDrawerView = new TKSideDrawerView (this.View.Bounds);
			this.SideDrawerView.AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth;
			this.View.AddSubview (this.SideDrawerView);

			UIImageView backgroundView = new UIImageView (this.SideDrawerView.MainView.Bounds);
			backgroundView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
			backgroundView.Image = UIImage.FromBundle ("sdk-examples-bg.png");
			this.SideDrawerView.MainView.AddSubview (backgroundView);

			UINavigationBar navBar = new UINavigationBar (new CGRect (0, 0, this.SideDrawerView.MainView.Bounds.Width, 44));
			navBar.AutoresizingMask = UIViewAutoresizing.FlexibleWidth;
			this.NavItem = new UINavigationItem ();
			UIBarButtonItem showSideDrawer = new UIBarButtonItem (UIImage.FromBundle ("menu.png"), UIBarButtonItemStyle.Plain, this, new Selector ("ShowSideDrawer"));
			this.NavItem.LeftBarButtonItem = showSideDrawer;
			navBar.Items = new UINavigationItem[] { this.NavItem };
			this.SideDrawerView.MainView.AddSubview (navBar);

			primarySection = new TKSideDrawerSection ("Primary");
			primarySection.AddItem ("Social");
			primarySection.AddItem ("Promotions");

			labelsSection = new TKSideDrawerSection ("Labels");
			labelsSection.AddItem ("Important");
			labelsSection.AddItem ("Starred");
			labelsSection.AddItem ("Sent Mail");
			labelsSection.AddItem ("Drafts");

			this.sideDrawerDelegate = new SideDrawerDelegate ();
			TKSideDrawer sideDrawer = this.SideDrawerView.SideDrawers[0];
			sideDrawer.HeaderView = new SideDrawerHeader (true, this, new Selector ("DismissSideDrawer"));
			sideDrawer.AddSection (primarySection);
			sideDrawer.AddSection (labelsSection);
			sideDrawer.Delegate = this.sideDrawerDelegate;
			sideDrawer.Style.HeaderHeight = 44;
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			if (this.NavigationController != null) {
				this.NavigationController.InteractivePopGestureRecognizer.Enabled = true;
			}

		}
			
		[Export ("ShowSideDrawer")]
		public void ShowSideDrawer()
		{
			this.SideDrawerView.SideDrawers[0].Show();
		}

		[Export ("DismissSideDrawer")]
		public void DismissSideDrawer()
		{
			this.SideDrawerView.SideDrawers[0].Dismiss();
		}

		class SideDrawerDelegate : TKSideDrawerDelegate
		{
			public override void UpdateVisualsForSection (TKSideDrawer sideDrawer, int sectionIndex)
			{
				TKSideDrawerSection section = sideDrawer.Sections[sectionIndex];
				section.Style.ContentInsets = new UIEdgeInsets (0, -15, 0, 0);
			}

			public override void UpdateVisualsForItem (TKSideDrawer sideDrawer, NSIndexPath indexPath)
			{
				TKSideDrawerItem item = sideDrawer.Sections[indexPath.Section].Items[indexPath.Item];
				item.Style.ContentInsets = new UIEdgeInsets (0, -5, 0, 0);
				item.Style.SeparatorColor = new TKSolidFill (UIColor.Clear);
			}
		}
	}
}

