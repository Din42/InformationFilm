using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using InformationFilm_1.Models;

namespace InformationFilm_1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; } = new()
        {
            new Movie("Фильм 1", "Режиссер 1", 2020, "Краткое описание 1"),
            new Movie("Фильм 2", "Режиссер 2", 2019, "Краткое описание 2"),
            new Movie("Фильм 3", "Режиссер 3", 2021, "Краткое описание 3")
        };

        public void OnGet(){ }
    }
}
