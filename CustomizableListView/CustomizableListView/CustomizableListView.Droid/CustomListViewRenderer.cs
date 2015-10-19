using Com.Telerik.Widget.List;
using Telerik.XamarinForms.DataControlsRenderer.Android;

namespace CustomizableListView.Droid
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        protected override Com.Telerik.Widget.List.SwipeExecuteBehavior CreateSwipeExecuteBehavior(ListViewDataSourceAdapter adapter)
        {
            var swipeExecuteBehavior = base.CreateSwipeExecuteBehavior(adapter);
            swipeExecuteBehavior.AutoDissolve = false;

            return swipeExecuteBehavior;
        }
    }
}