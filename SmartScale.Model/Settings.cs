using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class Settings
    {
        [Key]
        [Display(Name = "ID")]
        public int SettingId { get; set; }
        [Display(Name = "Descriere")]
        public string SettingName { get; set; }
        [Display(Name = "Valoare")]
        public string SettingValue { get; set; }
    }
}
