namespace NavegacionColaborativa5363922;
/// <summary>
/// <createddate> 01/07/2024 </createddate> 
///<company>INSTITUTO NACIONAL CANTON LOURDES</company>
///<lastmodificationdate> 01/07/2024 </lastmodificationdate>
///<lastmodificationdescription> Se coloca el codigo que dara funcion a la app</lastmodificationdescription>
///<lastmodifierautor> Yony David Rodríguez Chávez </lastmodifierautor>
/// </summary>
public partial class About : ContentPage
{
    /// <summary>
    /// Se crea la navegacion a la siguiente pagina
    /// </summary>
	public About()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}