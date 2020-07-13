using MVC.Models.AttributeCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public string CodigoProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [DecimalAttribute(18, 2)]
        public decimal PrecioUnitario { get; set; }
        public int? CodigoCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public DateTime FechaProduccion { get; set; }
    }
}