using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class Soferi
    {
        //public Soferi()
        //{
        //    Masini = new Collection<Masini>();
        //}

        [Key]
        public int SoferId { get; set; }

        [Required]
        public string NumeSofer { get; set; }
        [Required]
        public string PrenumeSofer { get; set; }
        [Required]
        public string CNPSofer { get; set; }

        //public Collection<Masini> Masini { get; set; }
        public virtual ICollection<MasiniSofer> MasiniSoferi { get; set; }
    }
}
