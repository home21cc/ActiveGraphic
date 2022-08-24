///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: App.xaml.cs
// File Description: Application Global Attribute
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.3
// Create Date: 2022/08/09
// Final Update Date: 2022/08/24
///////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.Maui.Controls.Shapes;

namespace ActiveGraphic
{
    public partial class App : Application
    {
        readonly Style styleBorder = new(typeof(Border))
        {
            Setters =
            {
                new Setter() { Property = Border.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Border.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Border.PaddingProperty, Value = new Thickness(1, 1, 1, 1) },
            }
        };

        readonly Style styleBorderCell = new(typeof(Border))
        {
            Setters =
            {
                new Setter() { Property = Border.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Border.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Border.StrokeThicknessProperty, Value = new Thickness(0, 0, 0, 1) },
                new Setter() { Property = Border.PaddingProperty, Value = new Thickness(2, 2, 2, 2) },
            }
        };

        readonly Style styleButton = new(typeof(Button))
        {
            Setters =
            {
                new Setter() { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Button.VerticalOptionsProperty, Value = LayoutOptions.Fill },
                new Setter() { Property = Button.PaddingProperty, Value = new Thickness(1, 1, 1, 1) },
            }
        };

        readonly Style styleGrid = new(typeof(Grid))
        {
            Setters =
            {
                new Setter() { Property = Grid.HorizontalOptionsProperty, Value = LayoutOptions.Center},
                new Setter() { Property = Grid.VerticalOptionsProperty, Value = LayoutOptions.Center},
                new Setter() { Property = Grid.PaddingProperty, Value = 1},
                new Setter() { Property = Grid.ColumnSpacingProperty, Value = 1},
                new Setter() { Property = Grid.RowSpacingProperty, Value = 1},
            }
        };

        readonly Style styleHorizontalStackLayout = new(typeof(HorizontalStackLayout))
        {
            Setters =
            {

            }
        };

        readonly Style styleLabel = new(typeof(Label))
        {
            Setters =
            {
                new Setter() { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center },
                new Setter() { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
            }
        };

        readonly Style styleLine = new(typeof(Line))
        {
            Setters =
            {
                new Setter() { Property = Line.HorizontalOptionsProperty, Value = LayoutOptions.Center},
                new Setter() { Property = Line.VerticalOptionsProperty, Value = LayoutOptions.Center },
                new Setter() { Property = Rectangle.StrokeProperty, Value = Colors.Blue }
            }
        };

        readonly Style styleListView = new(typeof(ListView))
        {
            Setters =
            {
                new Setter() { Property = ListView.HorizontalScrollBarVisibilityProperty, Value = ScrollBarVisibility.Always },
                new Setter() { Property = ListView.HasUnevenRowsProperty, Value = false },
                new Setter() { Property = ListView.HorizontalOptionsProperty, Value = HorizontalAlignment.Center},
            }
        };

        readonly Style styleNavigation = new(typeof(NavigationPage))
        {
            Setters =
            {

            }
        };

        readonly Style stylePicker = new(typeof(Picker))
        {
            Setters =
            {

            }
        };

        readonly Style styleRectangle = new(typeof(Rectangle))
        {
            Setters =
            {
                new Setter() { Property = Rectangle.StrokeProperty, Value = Colors.Blue }
            }
        };

        readonly Style styleSlider = new(typeof(Slider))
        {
            Setters =
            {

            }
        };

        readonly Style styleVerticalStackLayout = new(typeof(VerticalStackLayout))
        {
            Setters =
            {

            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            Resources = new ResourceDictionary
            {
                {"StyleBorder", styleBorder },
                {"StyleBorderCell", styleBorderCell },
                {"StyleButton", styleButton },
                {"StyleGrid", styleGrid },
                {"StyleHorizontalStackLayout", styleHorizontalStackLayout },
                {"StyleLabel", styleLabel },
                {"StyleLine", styleLine },
                {"StyleListView", styleListView },
                {"StyleNavigation", styleNavigation },
                {"StylePicker", stylePicker },
                {"StyleRectangle", styleRectangle },
                {"StyleSlider", styleSlider },
                {"StyleVerticalStackLayout", styleVerticalStackLayout },
            };
        }
    }
}