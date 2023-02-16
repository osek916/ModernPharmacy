namespace ModernPharmacy.Client.Services.ArticleService
{
    public interface IArticleService
    {
        List<Article> Articles { get; set; }
        Article Article { get; set; }
        List<Tuple<string,  string>> ArticleTitlesAndPaths { get; set; }
        Task GetAllArticlesAsync();
        Task GetOnlyArticleTitlesAsync();
        Task GetArticleByTitleAsync(string title);
        Task GetArticleByIdAsync(int articleId);

    }
}
