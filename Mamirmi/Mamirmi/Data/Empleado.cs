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
    
    public partial class Empleado
    {
        public byte id { get; set; }
        public string Personaid { get; set; }
        public string cuenta_BN { get; set; }
        public string cuenta_BP { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}