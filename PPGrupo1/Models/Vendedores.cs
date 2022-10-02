using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PPGrupo1.Models
{
    public class Vendedores
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int VendedorId { get; set; }
        [Required]
        public int Codigo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Display(Name = "Porcentaje de Comision")]

        public decimal Comision { get; set; }
        public bool Activo { get; set; }

    }

    public class VendedoresDbContext : DbContext
    {
        public DbSet<Vendedores> Vendedor { get; set; }


    }



}