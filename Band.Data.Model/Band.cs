using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Band.Data.Model
{
    public class Bands
    {
        [Key]
        public int BandId { get; set; }

        public string BandName { get; set; }
        public string Genre { get; set; }
        public int Rating { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]

        public virtual User User { get; set; }
    }
}
