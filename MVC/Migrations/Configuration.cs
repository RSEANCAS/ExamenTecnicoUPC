namespace MVC.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.DbUPCContext>
    {
        public Configuration()
        {

            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Models.DbUPCContext context)
        {

            var cliente = new List<Models.Cliente>
            {
                new Models.Cliente { CodigoCliente = "71228362", Nombres = "Ronald", Apellidos = "Seancas", Email = "ronald.jsb@hotmai.com", Telefono = "954762805" },
                new Models.Cliente { CodigoCliente = "07264120", Nombres = "Zoraida", Apellidos = "Barreto", Email = "zoraida.1972@hotmail.com", Telefono = "951362655" }
            };

            var categoria = new List<Models.Categoria>
            {
                new Models.Categoria { CodigoCategoria = 1, Descripcion = "Categoría 1" },
                new Models.Categoria { CodigoCategoria = 2, Descripcion = "Categoría 2" }
            };

            var producto = new List<Models.Producto>
            {
                new Models.Producto { CodigoProducto = "PROD000001", CodigoCategoria = 1, Nombre = "PRODUCTO 1", Descripcion = "", FechaProduccion = new DateTime(2020, 1, 1), PrecioUnitario = 10M },
                new Models.Producto { CodigoProducto = "PROD000002", CodigoCategoria = 1, Nombre = "PRODUCTO 2", Descripcion = "", FechaProduccion = new DateTime(2020, 2, 1), PrecioUnitario = 20M },
                new Models.Producto { CodigoProducto = "PROD000003", CodigoCategoria = 2, Nombre = "PRODUCTO 3", Descripcion = "", FechaProduccion = new DateTime(2020, 3, 1), PrecioUnitario = 15M },
                new Models.Producto { CodigoProducto = "PROD000004", CodigoCategoria = 2, Nombre = "PRODUCTO 4", Descripcion = "", FechaProduccion = new DateTime(2020, 4, 1), PrecioUnitario = 30M },
            };

            var ordencompra = new List<Models.OrdenCompra>
            {
                new Models.OrdenCompra { CodigoCompra = 1, CodigoCliente = "71228362", FechaCompra = DateTime.Now, FechaEstimadaEntrega = DateTime.Now.AddDays(7) },
                new Models.OrdenCompra { CodigoCompra = 2, CodigoCliente = "71228362", FechaCompra = DateTime.Now, FechaEstimadaEntrega = DateTime.Now.AddDays(7) }
            };

            var ordencompradetalle = new List<Models.OrdenCompraDetalle>
            {
                new Models.OrdenCompraDetalle { CodigoCompra = 1, CodigoDetalle = 1, CodigoProducto = "PROD000001", PrecioUnitario = 10M, Cantidad = 1, ImporteTotal = 10M  },
                new Models.OrdenCompraDetalle { CodigoCompra = 1, CodigoDetalle = 2, CodigoProducto = "PROD000002", PrecioUnitario = 20M, Cantidad = 4, ImporteTotal = 80M  },
                new Models.OrdenCompraDetalle { CodigoCompra = 2, CodigoDetalle = 1, CodigoProducto = "PROD000003", PrecioUnitario = 15M, Cantidad = 2, ImporteTotal = 30M  },
                new Models.OrdenCompraDetalle { CodigoCompra = 2, CodigoDetalle = 2, CodigoProducto = "PROD000004", PrecioUnitario = 30M, Cantidad = 3, ImporteTotal = 90M  }
            };



            context.Cliente.AddOrUpdate(cliente.ToArray());
            context.Categoria.AddOrUpdate(categoria.ToArray());
            context.Producto.AddOrUpdate(producto.ToArray());
            context.OrdenCompra.AddOrUpdate(ordencompra.ToArray());
            context.OrdenCompraDetalle.AddOrUpdate(ordencompradetalle.ToArray());

            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
