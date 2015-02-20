using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Band.Models
{
    public class BandListViewModels
    {
        public string UserName { get; set; }
        public double AverageRating { get; set; }
        public List<BandViewModel> Bands { get; set; }

    }
    public class BandViewModel
    {
        public int BandId { get; set; }
        [Required]
        //Look these up in your free time. "Attributes"!
        // [StringLength(5)] 
        public string BandName  { get; set; }
        public string  Genre { get; set; }
        [Required]
        [DisplayName("Poster URL")]
        public string BandImage { get; set; }
        //Ints do neccesarily need validation
        public int Rating { get; set; }
    }
}