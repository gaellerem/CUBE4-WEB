namespace JamaisASec_Site.Models
{
public class Commande
{
    public int id { get; set; }
    public string reference { get; set; }
    public DateOnly date { get; set; }
    public string status { get; set; }

    // ? signifie peut-être null
    public int? clients_ID { get; set; }
    public int? fournisseurs_id { get; set; }

}
}
