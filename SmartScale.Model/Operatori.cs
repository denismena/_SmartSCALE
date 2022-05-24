using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class Operatori
    {
        [Key]
        public int OperatorId { get; set; }
        
        private string _numePrenumeOperator;
        [Required]
        public string NumePrenumeOperator { get; set; }

        [Required]
        public string ActIdentitateOperator { get; set; }
        [Required]
        public string CNPOperator { get; set; }
        public byte StatusOperator { get; set; }
        
    }
}
