namespace Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PreliminaryCalculation
    {
        [Key]
        [Column(Order = 1)]
        public int MenuId { get; set; }

        public virtual Menu Menu { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public float Quantity { get; set; }
    }
}
