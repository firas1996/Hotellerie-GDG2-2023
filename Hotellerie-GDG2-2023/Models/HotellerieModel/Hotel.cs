using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GDG2_2023.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Le Nom est un champ obligatoire !!")]
        [StringLength(20,MinimumLength = 3,ErrorMessage ="sss")]
        public string Nom { get; set; }
        [Range(1,5,ErrorMessage ="...")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage = "Le Ville est un champ obligatoire !!")]
        public string Ville { get; set; }
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$", ErrorMessage = "Le champ Site Web doit contenir une URL valide.")]
        [Display(Name ="Site Web")]
        [Required(ErrorMessage = "Le SiteWeb est un champ obligatoire !!")]
        public string SiteWeb { get; set; }
        public string Tel {  get; set; }
    }
}
