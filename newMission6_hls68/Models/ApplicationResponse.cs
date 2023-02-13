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
        public string category { get; set; }
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

        [Range(0,25,ErrorMessage = "Notes may not exceed 25 characters.")]
        public string notes { get; set; }

    }
}
