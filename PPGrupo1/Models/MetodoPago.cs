using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace PPGrupo1.Models
{
    public class MetodoPago
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int MetodoPagoId { get; set; }

        [Required]

        public string Descripcion { get; set; }
        [Display(Name = "Cantidad de dias")]

        public int CantidadDias { get; set; }
        public bool Activo { get; set; }


    }

    public class FacturacionProdDbContext : DbContext
    {
        public DbSet<MetodoPago> MetodoPag { get; set; }


    }



}