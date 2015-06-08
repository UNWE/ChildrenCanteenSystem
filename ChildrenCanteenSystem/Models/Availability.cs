namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Наличности")]
    public class Availability
    {
        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Column("КодПродукт")]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        [Column("Количество")]
        public float Quantity { get; set; }

        [Required]
        [Column("Партида")]
        public string Batch { get; set; }

        [Required]
        [Column("ЕдиничнаЦена")]
        public decimal UnitPrice { get; set; }
    }
}
