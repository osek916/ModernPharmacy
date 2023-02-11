namespace ModernPharmacy.Server.Services.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly DataContext _dataContext;

        public ArticleService(DataContext dataContext)
        {
            _dataContext = dataContext;
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
    }
}
