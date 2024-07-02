namespace NavegacionColaborativa5363922;
/// <summary>
     ///<createddate> 26/06/2024 </createddate>
     ///<company> INSTITUTO NACIONAL CANTON LOURDES</company>
     ///<lastmodificationdate> 26/06/2024 </lastmodificationdate>
     ///<lastmodificationdescription> Ise la interfaz de la aplicacion donde se pide los datos y se muestran los resultados </lastmodificationdescription>
     ///<lastmodifierautor> Daniel Steven López Hernández </lastmodifierautor>
/// </summary>
public partial class CambioCliente : ContentPage
{
	/// <summary>
	/// Se declaran variables
	/// </summary>
public CambioCliente()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Se genera el metodo donde calculara el precio de el articulo y el dinero entregado por el usuario para determinar el cambio
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void OnCounterClicked(object sender, EventArgs e)
    {

        if (double.TryParse(CostoEntry.Text, out double costo) &&
            double.TryParse(DineroEntregadoEntry.Text, out double dineroEntregado))
        {
            double cambio = dineroEntregado - costo;
            ResultadoLabel.Text = $"Cambio a entregar: {cambio:C}";
        }
        else
        {
            ResultadoLabel.Text = "Ingrese valores válidos.";
        }

    }
}