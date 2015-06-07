namespace Models
{
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int MeasurementUnitId { get; set; }

        public virtual MeasurementUnit MeasurementUnit { get; set; }

    }
}
