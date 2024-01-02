using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.Models.Users;
namespace Infrastructure.Models.Base
{
    public class BaseClass
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EditionDate { get; set; }
        public bool IsDeleted { get; set; }

        public int? DeletedBy { get; set; }


        [ForeignKey(nameof(DeletedBy))]
        public User? DeletedByUser { get; set; }
    }
}