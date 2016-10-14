using System.ComponentModel.DataAnnotations;

namespace FilmDatabas.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Title { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Length should be more than 0 minutes.")]
        public int Length { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Age limit")]
        [Range(15, int.MaxValue, ErrorMessage = "Age limit is from 15 years.")]
        public int AgeLimit { get; set; }

        [Display(Name = "Meta score")]
        [Range(0, 100, ErrorMessage = "Meta score should be between 0 - 100.")]
        public int MetaScore { get; set; }

        [Display(Name = "Length in hours")]
        public string LengthInHours
        {
            get
            {
                var hours = Length / 50;
                var minutes = Length - hours * 60;
                return $"{hours}:{minutes:00}";
            }
        }
    }

    public enum Genre
    {
        Drama,
        Action,
        Nature,
        [Display(Name = "Violence movie")]
        Violence,
        Motor,
        Sport
    }
}