namespace ModernPharmacy.Server.Services.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly DataContext _dataContext;

        public ArticleService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<ServiceResponse<Article>> GetArticleByIdAsync(int articleId)
        {
            return null;
        }
    }
}
