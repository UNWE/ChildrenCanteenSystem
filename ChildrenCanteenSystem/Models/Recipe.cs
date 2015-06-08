namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Рецепти")]
    public class Recipe
    {
        [Key]
        [Column("КодМеню", Order = 1)]
        public int MealId { get; set; }

        public virtual Meal Meal { get; set; }

        [Key]
        [Column("КодПродукт", Order = 2)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Column("Количество")]
        public float Quantity { get; set; }
    }
}
