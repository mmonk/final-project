using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VeganRecipe.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        
        public int RecipeID { get; set; }
        [ForeignKey("RecipeID")]
        public virtual Recipe Recipe { get; set; }

        [Required]
        [Display(Name = "Ingredient Name")]
        public string IngredientName { get; set; }

        [Required]
        [Display(Name = "Ingredient Quantity")]
        public string IngredientQuantity { get; set; }
    }
}