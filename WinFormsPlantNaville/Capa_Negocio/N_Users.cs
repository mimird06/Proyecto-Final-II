using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Capa_Datos;
using Capa_Entidades;

namespace Capa_Negocio
{
    /// <summary>
    /// Clase de Capa de Negocios
    /// </summary>
    public class N_Users
    {
        D_Users objd = new D_Users();

        //Declaracion de la dependencia de la Capa Entidad
        public DataTable N_user(E_Users obje) 
        {
            //Declaracion de que retorne los datos de la tabla de Datos en la Capa: Datos
            return objd.D_User(obje);
        }
    }
}
