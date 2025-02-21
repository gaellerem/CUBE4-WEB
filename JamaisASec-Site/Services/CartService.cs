using JamaisASec_Site.Models;

namespace JamaisASec_Site.Services
{
    public class CartService
    {

        public List<ArticlesCommande> SelectedArticles { get; set; } = new List<ArticlesCommande>();

        public void AddArticleToCart(Article article, int quantiteCommandee)
        {
            var existant = SelectedArticles.FirstOrDefault(a => a.Article.id == article.id);

            if (existant != null)
            {
                existant.quantite += 1; // ✅ Ajoute **1 seule unité** par clic
            }
            else
            {
                SelectedArticles.Add(new ArticlesCommande
                {
                    Article = article,
                    quantite = 1 // ✅ Ajoute 1 par défaut
                });
            }
        }

        public void RemoveArticleFromCart(ArticlesCommande articleCommande)
        {
            SelectedArticles.Remove(articleCommande);
        }

        public void remove(ArticlesCommande articleCommande)
        {
            SelectedArticles.Remove(articleCommande);
        }
    }
}
