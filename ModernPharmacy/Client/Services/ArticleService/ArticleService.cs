using System.Net.Http.Json;

namespace ModernPharmacy.Client.Services.ArticleService
{
    public class ArticleService : IArticleService
    {
        private readonly HttpClient _http;

        public ArticleService(HttpClient http)
        {
            _http = http;
        }

        public List<Article> Articles { get; set; }

        /*
        public async Task GetArticleByIdAsync(int articleId)
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<Article>>($"api/Article/{articleId}");
            if(response != null && response.Data != null)
            {

            }
        }
        */

        
    }
}
