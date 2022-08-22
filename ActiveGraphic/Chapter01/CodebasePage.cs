namespace ActiveGraphic.Chapter01
{
    internal class CodebasePage : ContentPage
    {
        readonly ScrollView scrollView = new();
        readonly VerticalStackLayout verticalStackLayout = new()
        {
            Spacing = 25,
            Padding = new Thickness(30, 0),
            VerticalOptions = LayoutOptions.Center,
        };
        readonly Image image = new()
        {
            Source = "dotnet_bot.png",
            HeightRequest = 200,
            HorizontalOptions = LayoutOptions.Center,
        };
        readonly Label label = new()
        {
            Text = "Hello, World!",
            FontSize = 32,
            HorizontalOptions = LayoutOptions.Center,
        };
        readonly Label label2 = new()
        {
            Text = "Welcome to .NET Multi-platform App UI",
            FontSize = 18,
            HorizontalOptions = LayoutOptions.Center,
        };
        readonly Button CounterBtn = new()
        {
            Text = "Click me",
            HorizontalOptions = LayoutOptions.Center,
        };
        int count = 0;
        public CodebasePage()
        {
            Content = scrollView;
            scrollView.Content = verticalStackLayout;
            verticalStackLayout.Children.Add(image);
            verticalStackLayout.Children.Add(label);
            verticalStackLayout.Children.Add(label2);
            verticalStackLayout.Children.Add(CounterBtn);
            CounterBtn.Clicked += OnCounterClicked;
        }


        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
