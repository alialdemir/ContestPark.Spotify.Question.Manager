using System.Collections.Generic;

namespace ContestPark.Spotify.Question.Manager.Models
{
    public class SubCategory
    {
        public short SubCategoryId { get; set; }
        public short CategoryId { get; set; }
        public byte DisplayOrder { get; set; }
        public string DisplayPrice { get; set; }
        public decimal Price { get; set; }
        public string PicturePath { get; set; }
        public bool Visibility { get; set; }
        public List<SubCategoryLang> SubCategoryLangs { get; set; } = new List<SubCategoryLang>();
    }
}