//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FUJI.ListenerSCP.Servicio.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_DET_ServicioSitio
    {
        public int intDetServicioID { get; set; }
        public Nullable<int> id_Sitio { get; set; }
        public Nullable<System.DateTime> datFechaSCP { get; set; }
        public Nullable<System.DateTime> datFechaSCU { get; set; }
        public Nullable<System.DateTime> datFechaSync { get; set; }
    
        public virtual tbl_ConfigSitio tbl_ConfigSitio { get; set; }
    }
}
