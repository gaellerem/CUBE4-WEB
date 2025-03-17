using JamaisASec_Site.Models;

namespace JamaisASec_Site.Services
{
    public class CartService
    {

        public List<ArticlesCommande> SelectedArticles { get; set; } = new List<ArticlesCommande>();

        public void AddArticleToCart(Article article, int quantiteCommandee)
        {
            var existant = SelectedArticles.FirstOrDefault(a => a.article.id == article.id);

            if (existant != null)
            {
                existant.quantite += quantiteCommandee; // ✅ Ajoute **1 seule unité** par clic
            }
            else
            {
                SelectedArticles.Add(new ArticlesCommande
                {
                    article = article,
                    quantite = quantiteCommandee// ✅ Ajoute 1 par défaut
                });
            }
        }


        public void remove(ArticlesCommande articleCommande)
        {
            SelectedArticles.Remove(articleCommande);
        }
    }
}
