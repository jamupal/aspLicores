//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspLicores
{
    using System;
    using System.Collections.Generic;
    
    public partial class detalle_Factura
    {
        public int idDetalle { get; set; }
        public int codigo_Producto { get; set; }
        public int cantidad { get; set; }
        public decimal valor { get; set; }
        public int codigo_Factura { get; set; }
    
        public virtual factura factura { get; set; }
        public virtual licores licores { get; set; }
    }
}
