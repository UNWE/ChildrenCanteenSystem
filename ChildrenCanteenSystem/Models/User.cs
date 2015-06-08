namespace Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Потребители")]
    public class User
    {
        public User()
        {
            this.Roles = new HashSet<Role>();
        }

        [Key]
        [Column("Код")]
        public int Id { get; set; }

        [Required]
        [Column("Име")]
        public string FirstName { get; set; }

        [Required]
        [Column("Фамиилия")]
        public string LastName { get; set; }

        [Required]
        [Column("ПотребителскоИме")]
        public string Username { get; set; }

        [Required]
        [Column("Парола")]
        public string Password { get; set; }

        public virtual ICollection<Role> Roles { get; set; } 
    }
}
