namespace ModernPharmacy.Server.Services.ArticleService
{
    public interface IArticleService
    {
        Task<ServiceResponse<Article>> GetArticleByIdAsync(int articleId);
    }
}
