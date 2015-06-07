namespace Models
{
    using System.ComponentModel.DataAnnotations;

    public class MealType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
