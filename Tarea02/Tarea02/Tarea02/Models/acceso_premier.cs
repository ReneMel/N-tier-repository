//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tarea02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class acceso_premier
    {
        public int id { get; set; }
        public int pelicula_id { get; set; }
        public int persona_id { get; set; }
    
        public virtual pelicula pelicula { get; set; }
        public virtual persona persona { get; set; }
    }
}
