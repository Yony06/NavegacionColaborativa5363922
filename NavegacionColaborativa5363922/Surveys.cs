using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegacionColaborativa5363922
{
    /// <summary>
    ///<createddate> 03/07/2024 </createddate>
    ///<company> INSTITUTO NACIONAL CANTON LOURDES</company>
    ///<lastmodificationdate> 03/07/2024 </lastmodificationdate>
    ///<lastmodificationdescription> Hacemos public la clase</lastmodificationdescription>
    ///<lastmodifierautor> Yony David Rodriguez Chavez </lastmodifierautor>
    /// </summary>
    public class Surveys
    {
        /// <summary>
        /// Obtiene o establece el nombre de la persona.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de nacimiento de la persona.
        /// </summary>
        public DateTime Birthdate { get; set; }
        /// <summary>
        /// Obtiene o establece el equipo favorito de la persona.
        /// </summary>
        public string FavoriteTeam { get; set; }
        /// <summary>
        /// Devuelve una cadena que representa la encuesta.
        /// </summary>
        public override string ToString()
        {
            return $"{Name} | {Birthdate} | {FavoriteTeam}";
        }
    }
}
