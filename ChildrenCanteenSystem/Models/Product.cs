namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Продукти")]
    public class Product
    {
        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Required]
        [Column("Име")]
        public string Name { get; set; }

        [Column("КодМернаЕдиница")]
        public int MeasurementUnitId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }

    }
}
