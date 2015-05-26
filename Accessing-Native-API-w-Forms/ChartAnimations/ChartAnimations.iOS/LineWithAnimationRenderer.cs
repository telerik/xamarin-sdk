using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace ChartAnimations.iOS
{
	public class LineWithAnimationRenderer : Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartRenderer
	{
		public LineWithAnimationRenderer()
		{
		}

		protected override void UpdateNativeWidget()
		{
			base.UpdateNativeWidget();
			this.Control.AllowAnimations = true;
		}

		protected override Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartDelegate CreateChartDelegateOverride()
		{
			return new LineWithAnimationDelegate();
		}
	}
}