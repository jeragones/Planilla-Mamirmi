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
    
    public partial class Usuario
    {
        public string IdPersona { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }
        public int TipoUsuario { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}
