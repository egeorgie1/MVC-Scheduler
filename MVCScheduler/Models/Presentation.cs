using System;
using System.ComponentModel.DataAnnotations;

namespace MVCScheduler.Models
{
    public class Presentation
    {
        [Required(ErrorMessage = "Please enter the number of your presentation")]
        public int? PresNumber { get; set; }

        [Required(ErrorMessage = "Please enter the topic of your presentation")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Speaker { get; set; }

        [Required(ErrorMessage = "Please enter the date and time of your presentation")]
        public DateTime? PresDateAndTime { get; set; }

        public int? PresLength { get; set; }
    }
}
