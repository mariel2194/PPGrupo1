using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;


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
       
        public virtual Categoria Categoria { get; set; }


    }

    public class ProductosDbContext : DbContext
    {
        public DbSet<Productos> Producto { get; set; }


    }



}