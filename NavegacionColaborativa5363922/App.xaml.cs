
namespace NavegacionColaborativa5363922
{
    /// <summary>
    /// <createddate> 26/06/2024 </createddate>
    ///<company>INSTITUTO NACIONAL CANTON LOURDES</company>
    ///<lastmodificationdate> 26/06/2024 </lastmodificationdate>
    ///<lastmodificationdescription>Configuramos el App</lastmodificationdescription>
    ///<lastmodifierautor> Andrea Rocio Pérez Arriola </lastmodifierautor>
    /// </summary>
  
    public partial class App : Application
    {

        /// <summary>
        ///<lastmodificationdescription> Se hace referencia para que la MainPage aparezca como pagina principal </lastmodificationdescription>
        /// </summary>
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
