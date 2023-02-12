using System.Net.Http.Json;

namespace ModernPharmacy.Client.Services.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient _http;
        public List<Article> Articles { get; set; }
        public List<string> ArticleTitles { get; set; }

        public ArticleService(HttpClient http)
        {
            _http = http;
        }

        /*
        public async Task GetArticleByIdAsync(int articleId)
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<Article>>($"api/Article/{articleId}");
            if(response != null && response.Data != null)
            {

            }
        }
        */

        public async Task GetAllArticlesAsync()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<Article>>>($"api/Article");
            if(response != null && response.Data != null)
            {
                Articles = response.Data;
            }
        }

        public async Task GetOnlyArticleTitlesAsync()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/Article/Title");
            if (response != null && response.Data != null)
            {
                ArticleTitles = response.Data;
            }
        }
    }
}
