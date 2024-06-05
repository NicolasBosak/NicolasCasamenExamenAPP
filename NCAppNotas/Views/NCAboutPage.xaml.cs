namespace NCAppNotas.Views;

public partial class NCAboutPage : ContentPage
{
    public NCAboutPage()
    {
        InitializeComponent();
    }
    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
        if (BindingContext is NCModels.NCAbout about)
        {
            await Launcher.Default.OpenAsync(about.MoreInfoUrl);
        }
    }
}