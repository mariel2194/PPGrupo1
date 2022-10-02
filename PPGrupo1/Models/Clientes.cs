using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Fluent.Infrastructure.FluentModel;

namespace PPGrupo1.Models
{
    public class Clientes
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int ClienteId { get; set; }

        
        [Required]
        [Display(Name = "RNC/Cedula")]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Comercial")]

        public string Nombre { get; set; }

        [StringLength(50)] 
        public string Telefono { get; set; }

        [Required]
        [StringLength(50)] 
        public string Email { get; set; }


        [Required]
        [ForeignKey("MetodoPago")]
        public int MetodoPagoId { get; set; }
        public virtual MetodoPago MetodoPago { get; set; }

        public bool Activo { get; set; }


    }

    public class ClientesProdDbContext : ApplicationDbContext
    {
        public DbSet<Clientes> Cliente { get; set; }


    }



}