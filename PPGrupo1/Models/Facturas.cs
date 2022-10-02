using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Fluent.Infrastructure.FluentModel;


namespace PPGrupo1.Models
{
    public class Facturas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int FacturaId { get; set; }
                   

        [Required]
        [Column(TypeName ="datetime")]
        public string Fecha { get; set; }

        // Foreign key to MetodoPago

        [Required]
        [ForeignKey("MetodoPago")]
        public int MetodoPagoId { get; set; }
        public virtual MetodoPago MetodoPago { get; set; }

        // Foreign key to Vendedor

        [Required]
        [ForeignKey("Vendedores")]
        public int VendedorId { get; set; }
        public virtual Vendedores Vendedores { get; set; }


    }

    public class FacturasProdDbContext : ApplicationDbContext
    {
        public DbSet<Facturas> Factura { get; set; }


    }



}