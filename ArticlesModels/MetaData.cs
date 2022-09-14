using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesModels
{
    public class MetaData
    {
        [Key]
        public int ID { get; set; }

        public string metadatas { get; set; } = null!;
    }
}
