using DomainModels;

namespace DTOs
{
    public class MovieModel : BaseEntity
    {
        public string Title{ get; set; }
        public string  Description{ get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
    }
}
