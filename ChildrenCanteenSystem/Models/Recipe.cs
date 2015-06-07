namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Recipe
    {
        [Key]
        [Column(Order = 1)]
        public int MealId { get; set; }

        public virtual Meal Meal { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public float Quantity { get; set; }
    }
}
