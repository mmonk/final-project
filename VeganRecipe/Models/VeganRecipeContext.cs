using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace VeganRecipe.Models
{
    public class VeganRecipeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VeganRecipeContext() : base("name=VeganRecipeContext")
        {
            Database.SetInitializer<VeganRecipeContext>(new DropCreateDatabaseAlways<VeganRecipeContext>());
        }

        public System.Data.Entity.DbSet<VeganRecipe.Models.Recipe> Recipes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<VeganRecipe.Models.Ingredient> Ingredients { get; set; }
    }
}
