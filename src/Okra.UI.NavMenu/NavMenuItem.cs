using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace Okra.UI.NavMenu
{
    [ContentProperty(Name = "Text")]
    public sealed class NavMenuItem : NavMenuButton
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(NavMenuItem), new PropertyMetadata(null));
        public static readonly DependencyProperty SymbolProperty = DependencyProperty.Register("Symbol", typeof(Symbol), typeof(NavMenuItem), new PropertyMetadata(null));

        public NavMenuItem()
        {
            this.DefaultStyleKey = typeof(NavMenuItem);
        }

        public Symbol Symbol
        {
            get { return (Symbol)GetValue(SymbolProperty); }
            set { SetValue(SymbolProperty, value); }
        }

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
    }
}
