using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MoviesInventory.Domain
{
    public class Movie
    {
        public int ID { get; set; }


        [Required]
        public string Title {get;set;}

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [DataType(DataType.MultilineText)]
        public string Note { get; set; }

        [Display(Name="Running Time in Minutes")]
        [Range(1,1000)]
        public UInt16 RunningTime { get; set; }

        public string Owner { get; set; }
        public string Barcode { get; set; }
        public string Format { get; set; }
        public string Location { get; set; }
        public string Rating { get; set; }
    }
}
