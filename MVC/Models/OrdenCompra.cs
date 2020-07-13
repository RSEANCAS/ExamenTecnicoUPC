using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("OrdenCompra")]
    public class OrdenCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodigoCompra { get; set; }
        public string CodigoCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaEstimadaEntrega { get; set; }
    }
}