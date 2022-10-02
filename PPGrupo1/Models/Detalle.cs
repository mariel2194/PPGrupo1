using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Fluent.Infrastructure.FluentModel;
using System.Data.Entity;


namespace PPGrupo1.Models
{
    public class Detalle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DetalleId { get; set; }

        // Foreign key to Productos
        [Required]
        [ForeignKey("Productos")]
        public int ProductosId { get; set; }
        public virtual Productos Productos { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        [Required]
        [ForeignKey("Facturas")]
        public int FacturaId { get; set; }
        public virtual Facturas Facturas { get; set; }




    }

    public class DetalleProdDbContext : ApplicationDbContext
    {
        public DbSet<Detalle> Detalle { get; set; }


    }
}