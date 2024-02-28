namespace esercizio2_mvc_backend.Models
{
    public class Scarpa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }
        public string ImmagineCopertina { get; set; }
        public string ImmagineAggiuntiva1 { get; set; }
        public string ImmagineAggiuntiva2 { get; set; }
        public bool InVendita { get; set; }
    }
}