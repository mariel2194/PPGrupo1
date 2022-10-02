using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PPGrupo1.Models
{
    public class Facturas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int FacturaId { get; set; }
                   

        public string Fecha { get; set; }

        // Foreign key to MetodoPago

        public virtual MetodoPago MetodoPago { get; set; }

        // Foreign key to Vendedor

        
        public virtual Vendedores Vendedores { get; set; }


    }

    public class FacturasProdDbContext : DbContext
    {
        public DbSet<Facturas> Factura { get; set; }


    }



}