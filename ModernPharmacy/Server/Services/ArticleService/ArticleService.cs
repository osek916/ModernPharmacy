namespace ModernPharmacy.Server.Services.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly DataContext _dataContext;

        public ArticleService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<List<Article>>> GetAllArticlesAsync()
        {
            var response = new ServiceResponse<List<Article>>
            {
                Data = await _dataContext.Articles
                .Include(a => a.Tags)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<Article>> GetArticleByIdAsync(int articleId)
        {
            if(articleId < 1)
                throw new BadRequestException($"Article id must be greater than {articleId}");

            var response = new ServiceResponse<Article>();
            var article = await _dataContext.Articles.FirstOrDefaultAsync(a => a.Id == articleId);
            if(article == null)
            {
                throw new NotFoundException($"Article doesn't exist");
            }

            response.Data = article;
            return response;
        }

        public async Task<ServiceResponse<Article>> GetArticleByTitleAsync(string title)
        {
            if (title == string.Empty)
                throw new BadRequestException($"Title cannot be empty");

            var response = new ServiceResponse<Article>();
            var article = await _dataContext.Articles.FirstOrDefaultAsync(a => a.Title == title);
            if (article == null)
            {
                throw new NotFoundException($"Article doesn't exist");
            }

            response.Data = article;
            return response;
        }

        public async Task<ServiceResponse<List<Tuple<string,string>>>> GetOnlyArticleTitlesAsync()
        {
            var response = new ServiceResponse<List<Tuple<string,string>>>();
            List<Tuple<string, string>> articles = await _dataContext.Articles.Select(a => new Tuple<string, string>(a.Title, a.ImagePath))
                .ToListAsync();

            if(articles == null)
            {
                throw new NotFoundException($"Article doesnt exist");
            }

            response.Data = articles;
            return response;
        }
    }
}
