//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDLibro_EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Libro
    {
        public int Idlibro { get; set; }
        public string Titulo { get; set; }
        public string Edicion { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public Nullable<int> Paginas { get; set; }
        public string Editorial { get; set; }
        public string Ciudadypais { get; set; }
        public Nullable<System.DateTime> Fechadeedicion { get; set; }
    }
}
