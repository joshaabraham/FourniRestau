using ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleService
{
    public interface IArticleService
    {
        Task<Article> Post(Article article);

        Task<Article> Update(Article article);

        Task Delete(int id);

        Task<List<Article>> GetAllbyMetaData();

        Task<List<Article>> GetAll();



    }
}
