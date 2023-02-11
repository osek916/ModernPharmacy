namespace ModernPharmacy.Server.Services.ArticleService
{
    public interface IArticleService
    {
        Task<ServiceResponse<Article>> GetArticleByIdAsync(int articleId);
        Task<ServiceResponse<Article>> GetArticleByTitleAsync(string title);
        Task<ServiceResponse<List<Article>>> GetAllArticlesAsync();
    }
}
