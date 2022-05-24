using System.ComponentModel.DataAnnotations;

namespace SmartScales.Model
{
    public class Articole
    {
        [Key]
        public int ArticolId { get; set; }
        public string DenumireArticol { get; set; }
        public byte StatusArticol { get; set; }
    }
}
