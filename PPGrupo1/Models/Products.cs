using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;



namespace PPGrupo1.Models

{
    public class Products
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int ProductsId { get; set; }
        [Required]
        public int Codigo { get; set; }
        [Display(Name = "Descripcion Articulo")]
        public string Descripcion { get; set; }
        [Display(Name = "Precio Unitario")]

        [Required]
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
        public int Stock { get; set; }


        // Foreign key to Categoria

       public virtual Categoria Categoria { get; set; }


    }

    public class ProductsDbContext : DbContext
    {
        public DbSet<Products> Product { get; set; }


    }



}