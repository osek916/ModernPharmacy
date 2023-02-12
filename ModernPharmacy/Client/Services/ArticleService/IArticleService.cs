namespace ModernPharmacy.Client.Services.ArticleService
{
    public interface IArticleService
    {
        List<Article> Articles { get; set; }

        //Task GetArticleByIdAsync();
        Task GetAllArticlesAsync();
        Task GetOnlyArticleTitlesAsync();
    }
}
