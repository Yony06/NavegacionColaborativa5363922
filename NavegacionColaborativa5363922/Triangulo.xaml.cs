namespace NavegacionColaborativa5363922;

    /// <summary>
    ///<createddate> 26/06/2024 </createddate>
    ///<company> INSTITUTO NACIONAL CANTON LOURDES</company>
    ///<lastmodificationdate> 26/06/2024 </lastmodificationdate>
    ///<lastmodificationdescription> Ise la interfaz de la aplicacion donde se pide los datos y se muestran los resultados </lastmodificationdescription>
    ///<lastmodifierautor> Daniel Steven López Hernández </lastmodifierautor>
    /// </summary>

public partial class Triangulo : ContentPage
{

    /// <summary>
    /// Se declaran variables
    /// </summary>
    
    public Triangulo()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Se genera el metodo donde calcula la superficie de un triangulo dada su base y su altura
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (double.TryParse(alturaEntry.Text, out double altura) &&
           double.TryParse(baseEntry.Text, out double baseRectangulo))
        {
            double superficie = (altura * baseRectangulo) / 2;

            ResultadoLabel2.Text = $"Superficie: {superficie}";
        }
        else
        {
            DisplayAlert("Error", "Ingresa valores numéricos válidos", "OK");
        }
    }

}