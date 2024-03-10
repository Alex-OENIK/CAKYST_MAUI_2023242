using CommunityToolkit.Mvvm.Input;
using SemesterProject.Models;

namespace SemesterProject.GUI.ViewModels
{
    public partial class CreatePageViewModel
    {
        public string Title { get; } = "Add Movie";

        public string? NewMovieTitle { get; set; }
        public string? NewMovieDirector { get; set; }
        public string? NewMovieReleaseYear { get; set; }
        public string? NewMovieRating { get; set; }

        public CreatePageViewModel() { }

        [RelayCommand]
        public void Create()
        {
            if (NewMovieTitle != null && NewMovieDirector != null && NewMovieReleaseYear != null && NewMovieRating != null)
            {
                if (int.TryParse(NewMovieReleaseYear, out int year) && byte.TryParse(NewMovieRating, out byte rating))
                {
                    Movie newMovie = new(NewMovieTitle, NewMovieDirector, rating, year);
                    var param = new ShellNavigationQueryParameters { { "NewMovie", newMovie } };
                    Shell.Current.GoToAsync("..", param);
                }
            }
        }
    }
}
