﻿namespace JamaisASec_Site.Models
{
public class ArticlesCommande
{
    public Article article { get; set; }
    public int id { get; set; }
    public int quantite { get; set; }
    public int articles_ID { get; set; }
    public int commandes_ID { get; set; }
}


}
