namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Menu
    {
        public Menu()
        {
            this.Meals = new HashSet<Meal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime? Date { get; set; }

        public int? FoodCards { get; set; }

        public virtual ICollection<Meal> Meals { get; set; } 
    }
}
