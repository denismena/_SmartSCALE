using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class Furnizori
    {
        [Key]
        public int FurnizorId { get; set; }

        [Required]
        public string DenumireFurnizor { get; set; }
        [Required]
        public string CodFiscalFurnizor { get; set; }
        public string RegComFurnizor { get; set; }
        public string AdresaSediuFurnizor { get; set; }
        public string AdresaCorespondentaFurnizor { get; set; }
        public string PunctLucruFurnizor { get; set; }
        public byte StatusFurnizor { get; set; }        
    }
}
