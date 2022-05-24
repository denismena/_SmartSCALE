using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SmartScales.Model
{
    public class Clienti
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public string DenumireClient { get; set; }
        [Required]
        public string CodFiscalClient { get; set; }
        public string RegComClient { get; set; }
        public string AdresaSediuClient { get; set; }
        public string AdresaCorespondentaClient { get; set; } //in general este identica cu adresa sediu
        public string PunctLucruClient { get; set; }
        public byte StatusClient { get; set; }
    }
}
