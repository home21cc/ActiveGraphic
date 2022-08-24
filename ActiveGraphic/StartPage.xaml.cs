///////////////////////////////////////////////////////////////////////////////////////////////
// File Name: StartPage.xaml.cs
// File Description: 응용프로그램 시작
// Program Type: C# MAUI
// Creator: home21cc@gmail.com
// Version: 0.0.0.2
// Create Date: 2022/08/09
// Final Update Date: 2022/08/23
///////////////////////////////////////////////////////////////////////////////////////////////

using ActiveGraphic.Models;

using System.Reflection;

namespace ActiveGraphic
{
    public partial class StartPage : ContentPage
    {
        readonly List<MenuModel> lstMenus = new()
        {
            new MenuModel(0, "Chapter 01 Overview of Maui programming", "", "", ""),
            new MenuModel(1, "Chapter 01 Overview of Maui programming", "First program", "2", "Chapter01.MainPage"),
            new MenuModel(2, "Chapter 01 Overview of Maui programming", "Code file based program", "3.6", "Chapter01.CodebasePage"),
            new MenuModel(3, "Chapter 02 Maui graphic programming", "", "", ""),
            new MenuModel(4, "Chapter 02 Maui graphic programming", "Default coordinates in Maui", "1.1", "Chapter02.CoordinatesPage"),
            new MenuModel(5, "Chapter 02 Maui graphic programming", "Default coordinates in Maui", "1.1", "Chapter02.CoordinatesXamlPage"),
            new MenuModel(6, "Chapter 02 Maui graphic programming", "Custom coordinates in Maui", "1.2", "Chapter02.CustomCoordinatesPage"),
            new MenuModel(7, "Chapter 02 Maui graphic programming", "Custom coordinates in Maui", "1.2", "Chapter02.CustomCoordinatesXamlPage"),
            new MenuModel(8, "Chapter 02 Maui graphic programming", "Custom scale in Maui", "1.3", "Chapter02.CustomScalePage"),
            new MenuModel(9, "Chapter 02 Maui graphic programming", "Custom scale in Maui", "1.3", "Chapter02.CustomScaleXamlPage"),
        };


        public StartPage()
        {
            InitializeComponent();
            UserInit();
        }

        private void UserInit()
        {
            ListView lsvContents = new()
            {
                Style = (Style)Application.Current.Resources["StyleListView"],
                ItemsSource = lstMenus,
                ItemTemplate = new DataTemplate(() =>
                {
                    Label lblSequence = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleLabel"],
                        WidthRequest = 50,
                        FontSize = 14,
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                    };
                    lblSequence.SetBinding(Label.TextProperty, "Sequence");

                    Border brdSequence = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleBorderCell"],
                        HorizontalOptions = LayoutOptions.Start,
                        WidthRequest = 50,
                        Content = lblSequence,
                    };

                    Label lblChapterName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleLabel"],
                        HorizontalTextAlignment = TextAlignment.Start,
                        FontSize = 14,
                        FontAttributes = FontAttributes.Bold,
                        WidthRequest = 300,
                    };
                    lblChapterName.SetBinding(Label.TextProperty, "ChapterName");
                    Border brdChapterName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleBorderCell"],
                        HorizontalOptions = LayoutOptions.Start,
                        WidthRequest = 300,
                        Content = lblChapterName,
                    };

                    Label lblContentName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleLabel"],
                        WidthRequest = 250,
                    };
                    lblContentName.SetBinding(Label.TextProperty, "ContentName");
                    Border brdContentName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleBorderCell"],
                        HorizontalOptions = LayoutOptions.Start,
                        WidthRequest = 250,
                        Content = lblContentName,
                    };

                    Label lblContentNumber = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleLabel"],
                        WidthRequest = 50,
                        HorizontalTextAlignment = TextAlignment.Center,
                    };
                    lblContentNumber.SetBinding(Label.TextProperty, "ContentNumber");
                    Border brdContentNumber = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleBorderCell"],
                        HorizontalOptions = LayoutOptions.Start,
                        WidthRequest = 50,
                        Content = lblContentNumber,
                    };

                    Label lblPageName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleLabel"],
                        WidthRequest = 400,
                    };
                    lblPageName.SetBinding(Label.TextProperty, "PageName");
                    Border brdPageName = new()
                    {
                        Style = (Style)Application.Current.Resources["StyleBorderCell"],
                        HorizontalOptions = LayoutOptions.Start,
                        WidthRequest = 400,
                        Content = lblPageName,
                    };
                    Grid grdViewCell = new()
                    {
                        RowDefinitions =
                            {
                                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                            },
                        ColumnDefinitions =
                            {
                                new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) },
                                new ColumnDefinition { Width = new GridLength(300, GridUnitType.Absolute) },
                                new ColumnDefinition { Width = new GridLength(50, GridUnitType.Absolute) },
                                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                            },

                        Padding = new Thickness(1, 1, 1, 5),
                        Children = { brdSequence, brdChapterName, brdContentName, brdContentNumber, brdPageName },
                    };
                    Grid.SetRow(brdSequence, 0);
                    Grid.SetColumn(brdSequence, 0);
                    Grid.SetRow(brdChapterName, 0);
                    Grid.SetColumn(brdChapterName, 1);
                    Grid.SetColumnSpan(brdChapterName, 3);
                    Grid.SetRow(brdContentName, 1);
                    Grid.SetColumn(brdContentName, 1);
                    Grid.SetRow(brdContentNumber, 1);
                    Grid.SetColumn(brdContentNumber, 2);
                    Grid.SetRow(brdPageName, 1);
                    Grid.SetColumn(brdPageName, 3);

                    return new ViewCell
                    {
                        View = grdViewCell,
                    };
                }),
            };

            lsvContents.ItemSelected += LsvContents_ItemSelected;

            Border brdContenst = new()
            {
                Style = (Style)Application.Current.Resources["StyleBorder"],
                Content = lsvContents
            };

            vslMenuList.Add(brdContenst);
        }

        private void LsvContents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(((MenuModel)e.SelectedItem).PageName) || string.IsNullOrWhiteSpace(((MenuModel)e.SelectedItem).PageName))
            {
                App.Current.MainPage.DisplayAlert("Attion", "There are no example programs", "Yes");
            }
            else
            {

                Type type = Type.GetType(Assembly.GetExecutingAssembly().GetName().Name
                    + "." + ((MenuModel)e.SelectedItem).PageName);
                object instance = Activator.CreateInstance(type);
                Navigation.PushAsync((ContentPage)instance);
            }
        }
    }
}