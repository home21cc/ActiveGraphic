///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: CoordinatesPage.xaml.cs
// File Description: Coordinates Page
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.1
// Create Date: 2022/08/20
// Final Update Date: 2022/08/21
///////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.Maui.Controls.Shapes;

namespace ActiveGraphic.Chapter02;

public partial class CoordinatesPage : ContentPage
{
    private readonly Border brdMathLabel = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "Math coordinate",
            Style = (Style)Application.Current.Resources["StyleLabel"],
        },
    };

    private readonly Border brdMauiLabel = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "Maui coordinate",
            Style = (Style)Application.Current.Resources["StyleLabel"],
        },
    };

    private readonly Border brdMathLine = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Line()
        {
            X1 = 10,
            Y1 = 190,
            X2 = 190,
            Y2 = 10,
            Stroke = Colors.DarkRed,
            Style = (Style)Application.Current.Resources["StyleLine"],
        },
    };

    private readonly Border brdMauiLine = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Line()
        {
            X1 = 10,
            Y1 = 10,
            X2 = 190,
            Y2 = 190,
            Stroke = Colors.DarkBlue,
            Style = (Style)Application.Current.Resources["StyleLine"],
        },
    };

    public CoordinatesPage()
    {
        InitializeComponent();
        UserInit();
    }

    private void UserInit()
    {
        Grid grdMain = new()
        {
            WidthRequest = 400,
            HeightRequest = 240,
            Style = (Style)Application.Current.Resources["StyleGrid"],
            RowDefinitions =
            {
                new RowDefinition() { Height = new GridLength(40, GridUnitType.Absolute ) },
                new RowDefinition() { Height = new GridLength(200, GridUnitType.Absolute ) },
            },
            ColumnDefinitions =
            {
                new ColumnDefinition() { Width = new GridLength( 200, GridUnitType.Absolute ) },
                new ColumnDefinition() { Width = new GridLength( 200, GridUnitType.Absolute ) },
            },
            Children = {brdMathLabel, brdMauiLabel, brdMathLine, brdMauiLine},
        };
        Grid.SetRow(brdMathLabel, 0);
        Grid.SetColumn(brdMathLabel, 0);

        Grid.SetRow(brdMauiLabel, 0);
        Grid.SetColumn(brdMauiLabel, 1);

        Grid.SetRow(brdMathLine, 1);
        Grid.SetColumn(brdMathLine, 0);

        Grid.SetRow(brdMauiLine, 1);
        Grid.SetColumn(brdMauiLine, 1);

        this.Content = grdMain;
    }
}