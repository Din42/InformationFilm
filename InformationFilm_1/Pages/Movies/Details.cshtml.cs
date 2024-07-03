using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InformationFilm_1.Models;

namespace InformationFilm_1.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        public Movie Movies {  get; set; }
        public List<Movie> Movie { get; } = new()
        {
            new Movie("����� 1", "�������� 1", 2020, "������� �������� 1"),
            new Movie("����� 2", "�������� 2", 2019, "������� �������� 2"),
            new Movie("����� 3", "�������� 3", 2021, "������� �������� 3")
        };
            
        public void OnGet(int id)
        {
            if(id >= 0 && id < Movie.Count)
            {
                Movies = Movie[id];
            }        
        }
    }
}

