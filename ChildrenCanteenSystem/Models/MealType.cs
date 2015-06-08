namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ЯстияТипове")]
    public class MealType
    {
        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Required]
        [Column("Име")]
        public string Name { get; set; }
    }
}
