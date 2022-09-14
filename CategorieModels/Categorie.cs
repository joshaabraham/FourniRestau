using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorieModels
{
    public class Categorie
    {
        [Key]
        public Guid ID { get; set; }

        [Required]
        public string Nom { get; set; }
        public Categorie CatergorieLiee_amont { get; set; }
        public Categorie CategorieLiee_aval { get; set; }

        public Metadata Metadata { get; set; }

    }
}
