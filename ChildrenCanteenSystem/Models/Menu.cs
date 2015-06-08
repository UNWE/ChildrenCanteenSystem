namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Менюта")]
    public class Menu
    {
        public Menu()
        {
            this.Meals = new HashSet<Meal>();
        }

        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Required]
        [Column("Дата")]
        public DateTime? Date { get; set; }

        [Column("ЗакупениКупони")]
        public int? FoodCards { get; set; }

        public virtual ICollection<Meal> Meals { get; set; } 
    }
}
