using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace newMission6_hls68.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int movieId { get; set; }
       
        [Required]
        public string title{get; set;}
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }
        public bool edited { get; set; }
        public string lentTo { get; set; }

        [Range(0,25)]
        public string notes { get; set; }

        //build foreign key relationship 
        [Required]
        public int categoryId { get; set; }
        public Category category { get; set; }


    }
}
