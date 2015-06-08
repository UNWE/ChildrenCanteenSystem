namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Ястия")]
    public class Meal
    {
        public Meal()
        {
            this.Recipes = new HashSet<Recipe>();
            this.Menus = new HashSet<Menu>();
        }

        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Required]
        [Column("Име")]
        public string Name { get; set; }

        [Column("КодЯстиеТип")]
        public int MealTypeId { get; set; }

        public virtual MealType MealType { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }

        public virtual ICollection<Menu> Menus { get; set; } 
    }
}
