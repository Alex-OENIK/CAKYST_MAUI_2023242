using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SemesterProject.Models;

namespace SemesterProject.GUI.ViewModels
{
    [QueryProperty(nameof(MovieToEdit), "MovieToEdit")]
    public partial class UpdatePageViewModel : ObservableObject
    {
        public string Title { get; } = "Edit Movie";

        public Movie MovieToEdit
        {
            set
            {
                if (value != null)
                {
                    EditedMovieTitle = value.Title;
                    EditedMovieDirector = value.Director;
                    EditedMovieReleaseYear = value.ReleaseYear.ToString();
                    EditedMovieRating = value.Rating.ToString();
                }
            }
        }

        [ObservableProperty]
        private string? editedMovieTitle;
        [ObservableProperty]
        public string? editedMovieDirector;
        [ObservableProperty]
        public string? editedMovieReleaseYear;
        [ObservableProperty]
        public string? editedMovieRating;

        public UpdatePageViewModel() { }

        [RelayCommand]
        public void Update()
        {
            if (EditedMovieTitle != null && EditedMovieDirector != null && EditedMovieReleaseYear != null && EditedMovieRating != null)
            {
                if (int.TryParse(EditedMovieReleaseYear, out int year) && byte.TryParse(EditedMovieRating, out byte rating))
                {
                    Movie movieToUpdate = new(EditedMovieTitle, EditedMovieDirector, rating, year);
                    var param = new ShellNavigationQueryParameters { { "UpdatedMovie", movieToUpdate } };
                    Shell.Current.GoToAsync("..", param);
                }
            }
        }
    }
}
