//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class precios
    {
        public int Id { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Utilidad { get; set; }
        public Nullable<int> Id_Modelo { get; set; }
    
        public virtual Modelo Modelo { get; set; }
    }
}
