using SemesterProject.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;


namespace SemesterProject.GUI.ViewModels
{
    [QueryProperty(nameof(NewMovie), "NewMovie")]
    [QueryProperty(nameof(UpdatedMovie), "UpdatedMovie")]

    public partial class MainPageViewModel
    {
        public ObservableCollection<Movie> Movies { get; } = [];

        public Movie NewMovie
        {
            set
            {
                if (value != null)
                {
                    backend.Logic.Create(value);
                    RefreshList();
                }
            }
        }

        public Movie UpdatedMovie
        {
            set
            {
                if (value != null)
                {
                    backend.Logic.Update(value);
                    RefreshList();
                }
            }
        }

        public Movie? SelectedMovie { get; set; }

        public string Title { get; } = "MovieDB";

        readonly Backend backend;

        public MainPageViewModel(Backend backend)
        {
            this.backend = backend;
            RefreshList();
        }

        private void RefreshList()
        {
            Movies.Clear();
            foreach (Movie movie in backend.Logic.ReadAll()) { Movies.Add(movie); }
        }

        [RelayCommand]
        public static async Task Create()
        {
            await Shell.Current.GoToAsync("createpage");
        }

        [RelayCommand]
        public void Update()
        {
            if (SelectedMovie != null)
            {
                var param = new ShellNavigationQueryParameters { { "MovieToEdit", SelectedMovie } };
                Shell.Current.GoToAsync("updatepage", param);
            }
        }

        [RelayCommand]
        public void Delete()
        {
            if (SelectedMovie != null)
            {
                backend.Logic.Delete(SelectedMovie);
                Movies.Remove(SelectedMovie);
            }
        }
    }
}
