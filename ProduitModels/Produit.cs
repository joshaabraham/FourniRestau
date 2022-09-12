using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduitModels
{
    public class Produit
    {
        public Guid ProduitID { get; set; }
        public string Name { get; set; }
        public int Quantite { get; set; }
        public string Description { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
        public float Reduction { get; set; }
        public ProductPhotos ProductPhotos { get; set; }
        public Categories Categories { get; set; }
        public ProduitDescription ProduitDescription { get; set; }
        public ProduitAvantages Avantages { get; set; }
        public ProduitCertification Certification { get; set; }
        public ProduitExposition Exposition { get; set; }
        public ProduitLivraison ProduitLivraison { get; set; }
        public FAQ Faq { get; set; }
    }
}
