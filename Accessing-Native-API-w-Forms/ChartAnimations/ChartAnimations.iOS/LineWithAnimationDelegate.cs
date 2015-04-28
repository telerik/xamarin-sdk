using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using CoreGraphics;
using CoreAnimation;
using TelerikUI;


namespace ChartAnimations.iOS
{
	public class LineWithAnimationDelegate : Telerik.XamarinForms.ChartRenderer.iOS.CartesianChartDelegate
    {
        public LineWithAnimationDelegate()
        {
        }

        public override CAAnimation AnimationForSeries(TKChart chart, TKChartSeries series, TKChartSeriesRenderState state, CGRect rect)
        {
            double duration = 1;
            List<CAAnimation> animations = new List<CAAnimation>();

            for (int i = 0; i < (int)state.Points.Count; i++)
            {
                string keyPath = string.Format("seriesRenderStates.{0}.points.{1}.y", series.Index, i);
                TKChartVisualPoint point = (TKChartVisualPoint)state.Points.ObjectAtIndex((uint)i);
                double oldY = rect.Height;
                double half = oldY + (point.Y - oldY) / 2.0;
                CAKeyFrameAnimation a = (CAKeyFrameAnimation)CAKeyFrameAnimation.GetFromKeyPath(keyPath);
                a.KeyTimes = new NSNumber[] { new NSNumber(0), new NSNumber(0), new NSNumber(1) };
                a.Values = new NSObject[] { new NSNumber(oldY), new NSNumber(half), new NSNumber(point.Y) };
                a.Duration = duration;
                a.TimingFunction = CAMediaTimingFunction.FromName(CAMediaTimingFunction.EaseOut);
                animations.Add(a);
            }

            CAAnimationGroup group = new CAAnimationGroup();

            group.Duration = duration;
            group.Animations = animations.ToArray();

            return group;
        }
    }
}