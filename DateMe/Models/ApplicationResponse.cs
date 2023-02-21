using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        //makes submissionid the primary key
        [Key]
        [Required]
        public int SubmissionId { get; set; }
        [Required(ErrorMessage = "Category required")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year required")]
        public int Year { get; set; }
        [Required(ErrorMessage = "Director required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating required")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25, ErrorMessage = "The string must be less than 25 characters.")]
        public string Notes { get; set; }

    }
}
