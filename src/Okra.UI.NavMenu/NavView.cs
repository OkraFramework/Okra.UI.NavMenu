using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Okra.UI.NavMenu
{
    public sealed class NavView : Control
    {
        public static readonly DependencyProperty LargeWindowSnapPointProperty = DependencyProperty.Register("LargeWindowSnapPoint", typeof(double), typeof(NavView), new PropertyMetadata(1008.0));
        public static readonly DependencyProperty MediumWindowSnapPointProperty = DependencyProperty.Register("MediumWindowSnapPoint", typeof(double), typeof(NavView), new PropertyMetadata(641.0));
        public static readonly DependencyProperty MinWindowSnapPointProperty = DependencyProperty.Register("MinWindowSnapPoint", typeof(double), typeof(NavView), new PropertyMetadata(0.0));
        public static readonly DependencyProperty PaneProperty = DependencyProperty.Register("Pane", typeof(object), typeof(NavView), new PropertyMetadata(null));

        public NavView()
        {
            this.DefaultStyleKey = typeof(NavView);
        }

        public double LargeWindowSnapPoint
        {
            get { return (double)GetValue(LargeWindowSnapPointProperty); }
            set { SetValue(LargeWindowSnapPointProperty, value); }
        }

        public double MediumWindowSnapPoint
        {
            get { return (double)GetValue(MediumWindowSnapPointProperty); }
            set { SetValue(MediumWindowSnapPointProperty, value); }
        }

        public double MinWindowSnapPoint
        {
            get { return (double)GetValue(MinWindowSnapPointProperty); }
            set { SetValue(MinWindowSnapPointProperty, value); }
        }

        public object Pane
        {
            get { return (object)GetValue(PaneProperty); }
            set { SetValue(PaneProperty, value); }
        }
    }
}
