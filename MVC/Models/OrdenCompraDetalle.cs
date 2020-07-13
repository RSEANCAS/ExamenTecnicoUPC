using MVC.Models.AttributeCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("OrdenCompraDetalle")]
    public class OrdenCompraDetalle
    {
        [Key, Column(Order = 0)]
        public int CodigoCompra { get; set; }
        [Key, Column(Order = 1)]
        public int CodigoDetalle { get; set; }
        public string CodigoProducto { get; set; }
        public Producto Producto { get; set; }
        [DecimalAttribute(18, 2)]
        public decimal Cantidad { get; set; }
        [DecimalAttribute(18, 2)]
        public decimal PrecioUnitario { get; set; }
        [DecimalAttribute(18, 2)]
        public decimal ImporteTotal { get; set; }
    }
}