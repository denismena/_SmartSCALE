using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class CantarSetari
    {
        [Key]
        public int SetareCantarId { get; set; }
        public string NumeCantarGeneric { get; set; }
        public string ModelCantar { get; set; }
        public string TipCantar { get; set; }
        public string SerieCantar { get; set; }
        public string ClasaPrecizieCantar { get; set; }
        public string PunctDeCantarire { get; set; }
        public string PortSerialCantar { get; set; }
        public int BaudRateCantar { get; set; }
        public int DataBitsCantar { get; set; }
        public string StopBitsCantar { get; set; }
        public string ParityCantar { get; set; }
        public int ReadTimeoutCantar { get; set; }
        public int ReceivedBytesThresholdCantar { get; set; }
    }
}
