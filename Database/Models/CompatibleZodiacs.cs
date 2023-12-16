using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Database.Models
{
    public class CompatibleZodiacs
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? ZodiacId { get; set; }
        public int? CompatibleZodiacId { get; set; }
        [DeleteBehavior(DeleteBehavior.NoAction)]
        public virtual Zodiac? CompatibleZodiac { get; set; }
    }
}
