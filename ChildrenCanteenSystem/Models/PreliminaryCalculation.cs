namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ПредварителниКалкулации")]
    public class PreliminaryCalculation
    {
        [Key]
        [Column("КодМеню", Order = 1)]
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        [Key]
        [Column("КодПродукт", Order = 2)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        [Column("Количество")]
        public float Quantity { get; set; }
    }
}
