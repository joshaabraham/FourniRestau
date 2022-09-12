using ArticlesModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticleService
{
    public class ArticleService : IArticleService
    {
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Article>> GetAllbyMetaData()
        {
            throw new NotImplementedException();
        }

        public async Task<Article> Post(Article article)
        {
            throw new NotImplementedException();
        }

        public async Task<Article> Update(Article article)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetAll() { 
            
            throw new NotImplementedException(); 
        }
    }
}
