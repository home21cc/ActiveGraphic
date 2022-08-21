///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: App.xaml.cs
// File Description: Application Global Attribute
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.2
// Create Date: 2022/08/09
// Final Update Date: 2022/08/22
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

        readonly Style stylePage = new(typeof(NavigationPage))
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
                {"StyleGrid", styleGrid },
                {"StyleLabel", styleLabel },
                {"StyleLine", styleLine },
                {"StyleListView", styleListView },
                {"StylePage", stylePage }
            };
        }
    }
}