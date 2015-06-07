namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Request
    {
        [Key]
        [Column(Order = 1)]
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        [Key]
        [Column(Order = 2)]
        public int AvailabilityId { get; set; }

        public virtual Availability Availability { get; set; }

        [Required]
        public float Quantity { get; set; }
    }
}
