using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Maui.Controls.PlatformConfiguration;

namespace NCAppNotas.Views;

public partial class NCPaginaPrincipal : ContentPage
{
	public NCPaginaPrincipal()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(NCAllNotesPage), typeof(NCAllNotesPage));
        Routing.RegisterRoute(nameof(NCConteoCaracteres), typeof(NCConteoCaracteres));
        Routing.RegisterRoute(nameof(NCAboutPage), typeof(NCAboutPage));
    }
   
    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(NCAllNotesPage));
    }
    async void ContarClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(NCConteoCaracteres));
    }
    async void InformacionClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync(nameof(NCAboutPage));
    }
}