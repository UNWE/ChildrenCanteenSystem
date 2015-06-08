namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Искания")]
    public class Request
    {
        [Key]
        [Column("КодМеню", Order = 1)]
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        [Key]
        [Column("КодНаличност", Order = 2)]
        public int AvailabilityId { get; set; }

        public virtual Availability Availability { get; set; }

        [Required]
        [Column("Количество")]
        public float Quantity { get; set; }
    }
}
