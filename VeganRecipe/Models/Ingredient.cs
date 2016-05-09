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

        [ForeignKey("RecipeID")]
        public int RecipeID { get; set; }

        [Display(Name = "Ingredient Name")]
        public string IngredientName { get; set; }

        [Display(Name = "Ingredient Quantity")]
        public string IngredientQuantity { get; set; }
    }
}