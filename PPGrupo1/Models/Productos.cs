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
    public class Productos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int ProductoId { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Display(Name = "Descripcion Articulo")]
        public string Descripcion { get; set; }
        [Display(Name = "Precio Unitario")]
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
        public int Stock { get; set; }


        // Foreign key to Categoria

        [Required]
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }

    public class ProductosDbContext : ApplicationDbContext
    {
        public DbSet<Productos> Producto { get; set; }


    }



}