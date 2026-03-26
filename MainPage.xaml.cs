namespace MyMauiApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }

    private async void OnNextPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SecondPage());
    }
    private void OnHelloClicked(object sender, EventArgs e)
    {
        var vm = BindingContext as MainViewModel;
        vm?.SayHello();
    }
}