///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: CustomCoordinatesPage.xaml.cs
// File Description: Custom Coordinates Page
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.1
// Create Date: 2022/08/21
// Final Update Date: 2022/08/21
///////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.Maui.Controls.Shapes;

namespace ActiveGraphic.Chapter02;

public partial class CustomCoordinatesPage : ContentPage
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

    private readonly Border brdCustomLabel = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "Custom coordinate",
            Style = (Style)Application.Current.Resources["StyleLabel"],
        },
    };

    private readonly Border brdMathCoordinates = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "X1=10,Y1=190,X2=190,Y2=10",
            Style = (Style)Application.Current.Resources["StyleLabel"],
        },
    };

    private readonly Border brdMauiCoordinates = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "X1=10,Y1=10,X2=190,Y2=190",
            Style = (Style)Application.Current.Resources["StyleLabel"],
        },
    };

    private readonly Border brdCustomCoordinates = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Label()
        {
            Text = "X1=10,Y1=10,X2=190,Y2=190",
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
            X2 = 190,
            Y1 = 10,
            Y2 = 190,
            Stroke = Colors.DarkBlue,
            Style = (Style)Application.Current.Resources["StyleLine"],
        },
    };

    private readonly Border brdCustomLine = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        Content = new Line()
        {
            X1 = 10,
            X2 = 190,
            Y1 = 10,
            Y2 = 190,
            Stroke = Colors.DarkGreen,
            Style = (Style)Application.Current.Resources["StyleLine"],
        },
        ScaleY = -1,
    };

    public CustomCoordinatesPage()
	{
		InitializeComponent();
        UserInit();
	}

    private void UserInit()
    {
        Grid grdMain = new()
        {
            Style = (Style)Application.Current.Resources["StyleGrid"],
            RowDefinitions =
            {
                new RowDefinition() { Height = new GridLength(40, GridUnitType.Absolute ) },
                new RowDefinition() { Height = new GridLength(40, GridUnitType.Absolute )},
                new RowDefinition() { Height = new GridLength(200, GridUnitType.Absolute ) },
            },
            ColumnDefinitions =
            {
                new ColumnDefinition() { Width = new GridLength( 200, GridUnitType.Absolute ) },
                new ColumnDefinition() { Width = new GridLength( 200, GridUnitType.Absolute ) },
                new ColumnDefinition() { Width = new GridLength( 200, GridUnitType.Absolute ) },
            },
            Children = { brdMathLabel, brdMauiLabel, brdCustomLabel,
                brdMathCoordinates, brdMauiCoordinates, brdCustomCoordinates,
                brdMathLine, brdMauiLine, brdCustomLine },
        };
        Grid.SetRow(brdMathLabel, 0);
        Grid.SetColumn(brdMathLabel, 0);
        Grid.SetRow(brdMauiLabel, 0);
        Grid.SetColumn(brdMauiLabel, 1);
        Grid.SetRow(brdCustomLabel, 0);
        Grid.SetColumn(brdCustomLabel, 2);

        Grid.SetRow(brdMathCoordinates, 1);
        Grid.SetColumn(brdMathCoordinates, 0);
        Grid.SetRow(brdMauiCoordinates, 1);
        Grid.SetColumn(brdMauiCoordinates, 1);
        Grid.SetRow(brdCustomCoordinates, 1);
        Grid.SetColumn(brdCustomCoordinates, 2);

        Grid.SetRow(brdMathLine, 2);
        Grid.SetColumn(brdMathLine, 0);
        Grid.SetRow(brdMauiLine, 2);
        Grid.SetColumn(brdMauiLine, 1);
        Grid.SetRow(brdCustomLine, 2);
        Grid.SetColumn(brdCustomLine, 2);

        this.Content = grdMain;
    }
}