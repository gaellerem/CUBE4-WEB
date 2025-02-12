using JamaisASec_Site.Models;

namespace JamaisASec_Site.Services
{
    public class CartService
    {

        private List<Article> _selectedArticles {get; set;} = new();

        public List<Article> SelectedArticles
        {
            get => _selectedArticles;
            //set => _selectedArticles = value;
        }
        
        private Dictionary<int, int> _quantities { get; set; } = new Dictionary<int, int>();
        public Dictionary<int, int> Quantities
        {
            get => _quantities;
            //set => _quantities = value;
        }



        public void addArticleToCart(Article article)
        {
            _selectedArticles.Add(article);

            if (_quantities.ContainsKey(article.id))
            {
                _quantities[article.id]++;
            } else
            {
                _quantities[article.id] = 1;
            }

        }

        public void remove(Article article)
        {
            _selectedArticles.Remove(article);
        }
    }
}
