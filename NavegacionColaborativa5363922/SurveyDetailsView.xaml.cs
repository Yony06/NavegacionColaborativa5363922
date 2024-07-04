
using Microsoft.Maui.Controls;

namespace NavegacionColaborativa5363922;
	/// <summary>
	/// <createddate> 02/07/2024 </createddate> 
	///<company>INSTITUTO NACIONAL CANTON LOURDES</company>
	///<lastmodificationdate> 02/07/2024 </lastmodificationdate>
	///<lastmodificationdescription> Se coloca el coddigo que dara funcion a la app</lastmodificationdescription>
	///<lastmodifierautor> Andrea Rocio Pérez Arriola </lastmodifierautor>
	/// </summary>
public partial class SurveyDetailsView : ContentPage
{

    /// <summary>
    /// Lista de opciones de equipos que se le mostrara al usuario 
    /// </summary>
    private readonly string[] teams =
	{
		"Alianza Lima",
		"Amercia",
		"Boca Juniors",
		"Caracas FC",
		"Colo-Colo",
		"Perañol",
		"Real Madrid",
		"Saprissa"
	};

	/// <summary>
	/// 
	/// </summary>
	public SurveyDetailsView()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(NameEntry.Text) || string.IsNullOrWhiteSpace(FavoriteTeamLabel.Text))
        {
            return;
        }

        var newSurvey = new Surveys()
        {
            Name = NameEntry.Text,
            Birthdate = BirthdayPicker.Date,
            FavoriteTeam = FavoriteTeamLabel.Text
        };

        MessagingCenter.Send((ContentPage)this,
            Messages.NewSurveyComplete, newSurvey);
        await Navigation.PopAsync();
    }

	/// <summary>
	/// Mostrara un boton donde al tocarlo nos mostrara un listado con los 
	/// equipos y se ocultara temporalmente el boton al selecionar un equipo
	/// se mostrara en otro label, ocultara la lista y se volvera a mostrar el boton
	/// </summary>
	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		var favoriteTeam = await DisplayActionSheet(Literals.FavoriteTEamTitle, null,null,teams);
		if (!string.IsNullOrWhiteSpace(favoriteTeam))
		{
			FavoriteTeamLabel.Text = favoriteTeam;
		}

	
    }
}