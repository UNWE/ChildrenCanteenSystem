namespace Models
{
    using System.ComponentModel.DataAnnotations;

    public class Availability
    {
        [Key]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        [Required]
        public float Quantity { get; set; }

        [Required]
        public string Batch { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
    }
}
