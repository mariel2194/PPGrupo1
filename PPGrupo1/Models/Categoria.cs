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
    public class Categoria
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]
        public int CategoriaId { get; set; }

        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }

    public class CategoriaDbContext : ApplicationDbContext
    {
        public DbSet<Categoria> Categoria { get; set; }


    }
}