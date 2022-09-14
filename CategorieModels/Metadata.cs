using System.ComponentModel.DataAnnotations;

namespace CategorieModels
{
    public class Metadata
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Mot { get; set; }
    }
}