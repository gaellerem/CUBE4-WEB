using JamaisASec_Site.Models;

namespace JamaisASec_Site.Services
{
    public class CartService
    {
        private List<Article> selectedArticles {get; set;} = new List<Article>();
        private Dictionary<int, int> quantities { get; set; } = new Dictionary<int, int>();

        public void addArticleToCart(Article article)
        {
            selectedArticles.Add(article);

            if (quantities.ContainsKey(article.id))
            {
                quantities[article.id]++;
            } else
            {
                quantities[article.id] = 1;
            }

        }
    }
}
