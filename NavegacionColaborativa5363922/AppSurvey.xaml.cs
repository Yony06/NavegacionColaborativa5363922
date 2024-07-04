namespace NavegacionColaborativa5363922;

/// <summary>
/// <createddate> 30/06/2024 </createddate> 
///<company>INSTITUTO NACIONAL CANTON LOURDES</company>
///<lastmodificationdate> 30/06/2024 </lastmodificationdate>
///<lastmodificationdescription> Se coloca el coddigo que dara funcion a la app</lastmodificationdescription>
///<lastmodifierautor> Andrea Rocio Pérez Arriola </lastmodifierautor>
/// </summary>

public partial class AppSurvey : ContentPage
{
    /// <summary>
    /// Generamos el metodo del boton y configuramos para poder navegar 
    /// <return> Navega y nos muestra la siguiente página</return>
    /// </summary>
	public AppSurvey()
	{
		InitializeComponent();
        MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) =>
        {
            SurveysPanel.Children.Add(new Label() { Text = args.ToString() });
        });
    }

    /// <summary>
    /// Navegacion a la otra pagina
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void Button_Clicked(object sender, EventArgs e)
    {
     
       await Navigation.PushAsync(new SurveyDetailsView());
    }
}