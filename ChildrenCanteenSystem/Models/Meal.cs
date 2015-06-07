namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Meal
    {
        public Meal()
        {
            this.Recipes = new HashSet<Recipe>();
            this.Menus = new HashSet<Menu>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int MealTypeId { get; set; }

        public virtual MealType MealType { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Menu> Menus { get; set; } 
    }
}
