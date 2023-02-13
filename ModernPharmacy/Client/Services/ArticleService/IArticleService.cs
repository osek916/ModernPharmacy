﻿namespace ModernPharmacy.Client.Services.ArticleService
{
    public interface IArticleService
    {
        List<Article> Articles { get; set; }
        List<Tuple<string,string>> ArticleTitlesAndImages { get; set; }
        Task GetAllArticlesAsync();
        Task GetOnlyArticleTitlesAsync();
        Task GetArticleByTitleAsync(string title);
        Task GetArticleByIdAsync(int articleId);

    }
}
