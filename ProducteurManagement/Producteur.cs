using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducteurManagement
{
    public class Producteur
    {
        public Guid ID { get; set; }
        public string NomDeFamille { get; set; }
        public string Prenom { get; set; }
        public PhotoProfile PhotoProfile { get; set; }
        public int Age { get; set; }
        public Articles Articles { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public string Telephone { get; set; }

        public Production Production { get; set; }



    }
}
