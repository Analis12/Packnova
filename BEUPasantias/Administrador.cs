//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUPasantias
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrador
    {
        public int id { get; set; }
        public string claveAcceso { get; set; }
        public int idPersona { get; set; }
    
        public virtual Persona Persona { get; set; }
    }
}
