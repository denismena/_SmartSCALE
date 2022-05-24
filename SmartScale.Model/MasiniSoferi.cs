using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartScales.Model
{
    public class MasiniSofer
    {
        //[Key, Column(Order = 0)]
        //public int MasiniSoferId { get; set; }

        [Key, Column(Order = 0)]
        public int MemberID { get; set; }
        [Key, Column(Order = 1)]
        public int CommentID { get; set; }

        public virtual Masini Masini { get; set; }
        public virtual Soferi Soferi { get; set; }

        public DateTime DeLaData { get; set; }
        public DateTime? LaData { get; set; }
    }
}
