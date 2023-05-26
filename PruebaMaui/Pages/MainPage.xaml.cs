namespace PruebaMaui;

public partial class MainPage : ContentPage
{
    public string nombreUser { get; set; }
    public string contUser { get; set; }
    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {  
        if(nombreUser == "admin" && contUser=="1234") 
        {
            Application.Current.MainPage = new PaginaPrincipal();
        }
        else
        {
            DisplayAlert("Error","Usuario o clave incorrecta","Cancelar");
        }

        
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PaginaRegistro());
    }

    
}

