//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mamirmi.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vacaciones
    {
        public int id { get; set; }
        public string Personaid { get; set; }
        public System.DateTime fecha_Entrada { get; set; }
        public System.DateTime fecha_Salida { get; set; }
        public int dias { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}