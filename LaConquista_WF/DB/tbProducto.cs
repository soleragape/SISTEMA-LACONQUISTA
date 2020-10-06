//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LaConquista_WF.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProducto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProducto()
        {
            this.tbDetalleFactura = new HashSet<tbDetalleFactura>();
        }
    
        public int produ_IdProducto { get; set; }
        public Nullable<int> cprod_Id { get; set; }
        public Nullable<int> prove_IdProveedor { get; set; }
        public string produ_Codigo { get; set; }
        public string produ_Descripcion { get; set; }
        public Nullable<decimal> produ_PrecioCompra { get; set; }
        public Nullable<decimal> produ_PrecioVenta { get; set; }
        public Nullable<decimal> produ_Cantidad { get; set; }
        public string produ_Categoria { get; set; }
        public byte[] produ_Imagen { get; set; }
        public string produ_FormatoImagen { get; set; }
        public Nullable<bool> produ_Estado { get; set; }
        public Nullable<int> UsuarioCrea { get; set; }
        public Nullable<System.DateTime> FechaCrea { get; set; }
        public Nullable<int> UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
    
        public virtual tbCatalogoProductos tbCatalogoProductos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDetalleFactura> tbDetalleFactura { get; set; }
        public virtual tbProveedor tbProveedor { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
    }
}