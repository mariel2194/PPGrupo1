using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
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
        public virtual Productos Productos { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        [Required]
        public virtual Facturas Facturas { get; set; }




    }

    public class DetalleProdDbContext : DbContext
    {
        public DbSet<Detalle> Detalle { get; set; }


    }
}