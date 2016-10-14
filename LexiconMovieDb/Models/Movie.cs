using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconMovieDb.Models {

    public enum Genre {
        Drama,
        Horror,
        Comedy,
        DramaComedy,
        Action
    }
    public enum AgeLimit {
        [Display(Name = "No Limit")]
        NoLimit,
        [Display(Name = "From 3 yrs")]
        FromThree = 3,
        [Display(Name = "From 7 yrs")]
        FromSeven = 7,
        [Display(Name = "From 11 yrs")]
        FromEleven = 11,
        [Display(Name = "From 15 yrs")]
        FromFifteen = 15
    }

    public class Movie {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Only positive values")]
        public int Length { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Age Limit")]
        public AgeLimit AgeLimit { get; set; }
        [Range(0, 100, ErrorMessage = "0-100")]
        [Display(Name = "Meta Score")]
        public int MetaScore { get; set; }

        public string LengthInHours {
            get {
                var hours = Length / 60;
                var minutes = Length - hours * 60;
                return $"{hours}:{minutes:00}";
            }
        }
    }

}