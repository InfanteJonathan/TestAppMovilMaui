namespace PruebaMaui;
using PruebaMaui.Pages;
public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new FormMarca());
	}
}
