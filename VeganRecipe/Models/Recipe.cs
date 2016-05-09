using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VeganRecipe.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeID { get; set; }

        [Required]
        [Display(Name = "Recipe Name")]
        public string RecipeName { get; set; }

        [Required]
        [Display(Name = "Ingredient Name")]
        public virtual Ingredient IngredientName { get; set; }

        [Required]
        [Display(Name = "Ingredient Quantity")]
        public virtual Ingredient Quantity { get; set; }

        [Required]
        [Display(Name = "Ingredient Instructions")]
        public string RecipeInstructions { get; set; }
    }
}