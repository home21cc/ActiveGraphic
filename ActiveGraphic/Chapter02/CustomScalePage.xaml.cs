///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: CustomScalePage.xaml.cs
// File Description: Custom scale Page
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.1
// Create Date: 2022/08/24
// Final Update Date: 2022/08/24
///////////////////////////////////////////////////////////////////////////////////////////////


using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace ActiveGraphic.Chapter02;

public partial class CustomScalePage : ContentPage
{
    Line line = new()
    {
        Style = (Style)Application.Current.Resources["StyleLine"],
        Stroke = Colors.Red,
        X1 = 10,
        Y1 = 10,
        X2 = 190,
        Y2 = 190,
    };

    Rectangle rectangle = new()
    {
        Style = (Style)Application.Current.Resources["StyleRectangle"],
        Stroke = Colors.Blue,
        WidthRequest = 180,
        HeightRequest = 180,
    };

    Border brdShapeDraw = new()
    {
        Style = (Style)Application.Current.Resources["StyleBorder"],
        HorizontalOptions = LayoutOptions.Fill,
        VerticalOptions = LayoutOptions.Fill,
        Stroke = Colors.Black,
        StrokeThickness = 1,
        StrokeShape = new Rectangle(),
        ScaleY = -1,
    };


    Picker pkrShape = new()
    {
        Style = (Style)Application.Current.Resources["StylePicker"],
        WidthRequest = 100,
        HeightRequest = 30,
        ItemsSource = new List<string>()
        {
            new string("Line"),
            new string("Rectangle"),
        }
    };

    Button btnClear = new()
    {
        Style = (Style)Application.Current.Resources["StyleButton"],
        WidthRequest = 100,
        HeightRequest = 30,
        Text = "Clear"
    };

    Slider sldCoordinateX1Y1 = new()
    {
        Style = (Style)Application.Current.Resources["StyleSlider"],
        WidthRequest = 400,
        Minimum = 10,
        Maximum = 390,
    };

    Slider sldCoordinateX2Y2 = new()
    {
        Style = (Style)Application.Current.Resources["StyleSlider"],
        WidthRequest = 400,
        Minimum = 10,
        Maximum = 390,
    };

    Label lblX1Y1Coordinate = new()
    {
        Text = "X1: 10, Y1: 10",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        VerticalTextAlignment = TextAlignment.Center,
        WidthRequest = 200,
        HeightRequest = 30,
    };

    Label lblX2Y2Coordinate = new()
    {
        Text = "X2: 190, Y2: 190",
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        VerticalTextAlignment = TextAlignment.Center,
        WidthRequest = 200,
        HeightRequest = 30,
    };
    

    public CustomScalePage()
    {
        InitializeComponent();
        UserInit();
    }

    private void UserInit()
    {
        HorizontalStackLayout hslCommand = new()
        {
            Style = (Style)Application.Current.Resources["StyleHorizontalStackLayout"],
            Spacing = 10,
            Children = {
                pkrShape,
                lblX1Y1Coordinate,
                lblX2Y2Coordinate,
                btnClear,
            },
        };

        HorizontalStackLayout hslScale = new()
        {
            Style = (Style)Application.Current.Resources["StyleHorizontalStackLayout"],
            Spacing = 20,            
            Children =  { sldCoordinateX1Y1, sldCoordinateX2Y2 }
        };

        Grid grdMain = new()
        {
            Style = (Style)Application.Current.Resources["StyleGrid"],
            RowDefinitions =
            {
                new RowDefinition() { Height = new GridLength(400, GridUnitType.Absolute) },
                new RowDefinition() { Height = new GridLength(30, GridUnitType.Absolute) },
                new RowDefinition() { Height = new GridLength(30, GridUnitType.Absolute) },
            },
            ColumnDefinitions =
            {
                new ColumnDefinition() { Width = new GridLength(400, GridUnitType.Absolute) },
            },
            Children = { brdShapeDraw, hslScale, hslCommand },
        };
        Grid.SetRow(brdShapeDraw, 0);
        Grid.SetColumn(brdShapeDraw, 0);
        Grid.SetRow(hslScale, 1);
        Grid.SetColumn(hslScale, 0);
        Grid.SetRow(hslCommand, 2);
        Grid.SetColumn(hslCommand, 0);

        btnClear.Clicked += BtnClear_Clicked;
        pkrShape.SelectedIndexChanged += PkrShape_SelectedIndexChanged;
        sldCoordinateX1Y1.ValueChanged += SldCoordinateX1Y1_ValueChanged;
        sldCoordinateX2Y2.ValueChanged += SldCoordinateX2Y2_ValueChanged;

        this.Content = grdMain;
    }

    private void SldCoordinateX2Y2_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        switch(pkrShape.SelectedIndex)
        {
            case 0:
                line.X2 = e.NewValue;
                line.Y2 = e.NewValue;
                lblX2Y2Coordinate.Text = "X2: " + line.X2.ToString() + ", Y2: " + line.Y2.ToString();
                break;
            case 1:
                rectangle.WidthRequest = e.NewValue;
                rectangle.HeightRequest = e.NewValue;
                break;
            default:
                break;
        }
    }

    private void SldCoordinateX1Y1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        switch (pkrShape.SelectedIndex)
        {
            case 0:
                line.X1 = e.NewValue;
                line.Y1 = e.NewValue;
                lblX1Y1Coordinate.Text = "X1: " + line.X1.ToString() + ", Y1: " + line.Y1.ToString();
                break;
            case 1:
                break;
            default:
                break;
        }
    }

    private void PkrShape_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (pkrShape.SelectedIndex)
        {
            case 0:
                brdShapeDraw.Content = line;
                break;
            case 1:
                brdShapeDraw.Content = rectangle;
                break;
            default:
                brdShapeDraw.Content = null;
                break;
        }
    }

    private void BtnClear_Clicked(object sender, EventArgs e)
    {
        brdShapeDraw.Content = null;
    }
}