using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesModels
{
    public class Article
    {
        public int ArticleID { get; set; }
    
        public string Title { get; set; }

        public string Content { get; set; }

        public Author Author { get; set; }
        
        public MetaData MetaData { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }



    }
}
