namespace InformationFilm_1.Models
{
    //хранение информаци для фильмов
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public Movie(string title, string director, int year, string description)
        {
            Title = title;
            Director = director;
            Year = year;
            Description = description;
        }
    }
}
