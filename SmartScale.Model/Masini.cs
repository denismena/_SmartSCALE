using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace SmartScales.Model
{
    public class Masini
    {
        //public Masini()
        //{
        //    Soferi = new Collection<Soferi>();
        //}
        [Key]
        public int MasiniId { get; set; }

        [Required]
        public string NrAuto { get; set; }        
        public byte StatusMasina { get; set; }

        //public Collection<Soferi> Soferi { get; set; }
        public virtual ICollection<MasiniSofer> MasiniSoferi { get; set; }
    }
}
